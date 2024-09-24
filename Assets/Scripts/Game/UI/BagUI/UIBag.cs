using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIBag : UIBase
{
    private BagCtrl bagCtrl;

    [SerializeField]
    private GridLayoutGroup slotGroup;
    [SerializeField]
    private UINSlotItem slotItemPrototype;
    [SerializeField]
    private UINItem itemPrototype;
    [SerializeField]
    private RectTransform waitItemHolder;
    [SerializeField]
    private Button btn_TurnOver;
    [SerializeField]
    private Button btn_Map;
    [SerializeField]
    private UINItemDes desNode;

    [SerializeField]
    private UINBagMapNode mapNode;

    ObjectPool slotPool;
    ObjectPool itemPool;
    ObjectPool waitItemPool;
    ResLoader resLoader;

    [NonSerialized]
    public Dictionary<int, UINSlotItem> slotItemDic;
    [NonSerialized]
    public List<UINItem> itemList;

    public override void Awake()
    {
        GameManger.messageCenter.AddListernre(MsgType.onAddWaitItem, OnWaitItemChange);
        GameManger.messageCenter.AddListernre(MsgType.onMoveRoom, RefreshBag);
        resLoader = ResLoadManager.GetResLoader();
        slotItemDic = new Dictionary<int, UINSlotItem>();
        itemList = new List<UINItem>();

        slotPool = new ObjectPool(slotItemPrototype.gameObject);
        itemPool = new ObjectPool(itemPrototype.gameObject);
        waitItemPool = new ObjectPool(itemPrototype.gameObject, true, waitItemHolder);
        btn_TurnOver.onClick.AddListener(OnClickTurnOver);
        btn_Map.onClick.AddListener(OnClickMapBtn);

        slotGroup.constraint = GridLayoutGroup.Constraint.FixedColumnCount;

        desNode.gameObject.SetActive(false);

        base.Awake();
    }

    public void InitUIBag()
    {
        bagCtrl = GameManger.Instance.bagCtrl;

        slotGroup.constraintCount = bagCtrl.col;

        slotPool.RecycleAll();
        itemPool.RecycleAll();
        waitItemPool.RecycleAll();
        for (int y = 0; y < bagCtrl.row; y++)
        {
            for (int x = 0; x < bagCtrl.col; x++)
            {
                int coord = BagCtrl.GetCoordinateFromPos(x, y);
                BagSlotData slotData = bagCtrl.slotDic[coord];

                GameObject item = slotPool.GetOne();
                UINSlotItem slotItem = item.GetComponent<UINSlotItem>();
                slotItem.InitByData(slotData);

                slotItemDic.Add(coord, slotItem);
            }
        }

        mapNode.GenMap(resLoader);
        if (bagCtrl.bagState.HasFlag(eBagState.couldMoveItem))
        {
            mapNode.Hide();
        }

        RefreshBag();
    }

    /// <summary>
    /// 当等待被加入背包的Item发生变化
    /// </summary>
    private void OnWaitItemChange()
    {
        waitItemPool.RecycleAll();
        foreach (ItemBase itemData in bagCtrl.waitItemList)
        {
            var go = waitItemPool.GetOne();
            UINItem item = go.GetComponent<UINItem>();
            item.RefreshItem(resLoader, itemData, this);
            item.transform.localPosition = GetRandomWaitPos();
            var rectTransForm = item.GetComponent<RectTransform>();
            var curPos = rectTransForm.localPosition;
            rectTransForm.localPosition = new Vector3(curPos.x, curPos.y, 0);
            itemList.Add(item);
        }
    }

    private void OnClickTurnOver()
    {
        var epCtrl = GameManger.Instance.epCtrl;
        epCtrl.battleCtrl.PlayerTurnOver();
    }

    // 点击打开地图
    private void OnClickMapBtn() 
    {
        mapNode.Show();
    }

    private void RefreshBag()
    {
        EpCtrl epCtrl = GameManger.Instance.epCtrl;
        bool isInBattle = epCtrl.IsInBattle();

        btn_TurnOver.gameObject.SetActive(isInBattle);
        btn_Map.gameObject.SetActive(!isInBattle);
    }

    /// <summary>
    /// 随机生成点
    /// </summary>
    /// <returns></returns>
    private Vector3 GetRandomWaitPos()
    {
        var sizeDelta = waitItemHolder.sizeDelta / 2;
        float x = UnityEngine.Random.Range(-sizeDelta.x, sizeDelta.x);
        float y = UnityEngine.Random.Range(-sizeDelta.y, sizeDelta.y);
        return new Vector3(x, y, 0);
    }

    public void PutItemToBag(UINItem installItem)
    {
        if (waitItemPool.livingList.Contains(installItem.gameObject))
        {
            waitItemPool.RemoveOne(installItem.gameObject);
            itemPool.AddOne(installItem.gameObject);
        }
        installItem.transform.SetParent(itemPrototype.transform.parent.transform);
    }

    public void PopItem2Wait(ItemBase popItem)
    {
        foreach (var uinItem in itemList)
        {
            if (uinItem.itemData == popItem)
            {
                uinItem.transform.SetParent(waitItemHolder);
                uinItem.transform.localPosition = GetRandomWaitPos();
                uinItem.TryShowFloatTween();

                if (itemPool.livingList.Contains(uinItem.gameObject))
                {
                    waitItemPool.AddOne(uinItem.gameObject);
                    itemPool.RemoveOne(uinItem.gameObject);
                }
                return;
            }
        }
    }

    public Vector2 GetSlotCellSize()
    {
        return slotGroup.cellSize;
    }

    public Vector2 GetSlotSpaceSize()
    {
        return slotGroup.spacing;
    }

    public void ShowItemDes(bool isShow, ItemBase item = null)
    {
        desNode.gameObject.SetActive(isShow);
        if (!isShow)
            return;
        desNode.Refresh(item);
    }

    public void EnterWaitAddItemState()
    {
        mapNode.Hide();
    }

    public void FinishWaitAddItemState()
    {
        waitItemPool.RecycleAll();
    }

    private void OnDestroy()
    {
        GameManger.messageCenter.RemoveListernre(MsgType.onAddWaitItem, OnWaitItemChange);
        GameManger.messageCenter.RemoveListernre(MsgType.onMoveRoom, RefreshBag);
        ResLoadManager.RecycleResLoader(resLoader);
    }
}