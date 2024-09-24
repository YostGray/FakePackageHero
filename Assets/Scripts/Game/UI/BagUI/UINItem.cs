using System;
using System.Collections.Generic;
using Unity.Burst;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.U2D;
using UnityEngine.UI;
using DG.Tweening;

public class UINItem : UIBase, IPointerDownHandler, IPointerUpHandler, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    //逻辑大小到实际大小的转换
    const int ITEM_UNIT_SIZE = 140;

    [SerializeField]
    private UnityEngine.UI.Image img;
    [SerializeField]
    private float pressTime = 0.2f;//长按时间

    private BagCtrl bagCtrl;
    private UIBag uiBag;
    private RectTransform parentTransForm = null;
    private bool isPointerDown = false;
    private bool isClick = false;
    private bool isDraging = false;
    private float touchedTime = 0;
    private Vector3 startDragPos = Vector3.zero;
    private Vector2 dragRelativePos = Vector2.zero;
    public ItemBase itemData { private set; get; }

    private int? privateHoveredCoordinate = null;//缓存上次悬浮，减少计算用

    private void Start()
    {
        parentTransForm = this.gameObject.transform.parent.GetComponent<RectTransform>();
    }

    internal void RefreshItem(ResLoader resLoader, ItemBase itemData, UIBag uiBag)
    {
        this.itemData = itemData;
        this.uiBag = uiBag;
        bagCtrl = GameManger.Instance.bagCtrl;

        SpriteAtlas itemAtlas = resLoader.Load<SpriteAtlas>(PathHelper.GetAtlasePath("Item"));
        string resName = itemData.GetResName();
        img.sprite = itemAtlas.GetSprite(resName);
        RectTransform rectTransform = transform as RectTransform;
        rectTransform.sizeDelta = itemData.GetSize() * ITEM_UNIT_SIZE;
        rectTransform.pivot = itemData.GetPivote();

        TryShowFloatTween();
    }

    void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
    {
        isPointerDown = true;
        touchedTime = 0;
        isClick = true;
    }
    void IPointerUpHandler.OnPointerUp(PointerEventData eventData)
    {
        isPointerDown = false;
    }

    void IBeginDragHandler.OnBeginDrag(PointerEventData eventData)
    {
        if (!bagCtrl.IsCouldMoveItem())
            return;

        if (isClick)
            isClick = false;

        img.raycastTarget = false;
        startDragPos = transform.position;
        dragRelativePos = eventData.position - UIManager.Instance.World2ScreenPos(transform.position, UIManager.Instance.UICamera);
        isDraging = true;
        uiBag.ShowItemDes(true, itemData);
    }

    void IDragHandler.OnDrag(PointerEventData eventData)
    {
        if (!bagCtrl.IsCouldMoveItem())
            return;

        Vector3 newPos;
        RectTransformUtility.ScreenPointToWorldPointInRectangle(
            parentTransForm, eventData.position - dragRelativePos, UIManager.Instance.UICamera,out newPos);
        transform.position = newPos;

        TryShowWillInstallBlock();
    }

    void IEndDragHandler.OnEndDrag(PointerEventData eventData)
    {
        if (!bagCtrl.IsCouldMoveItem())
            return;

        isDraging = false;
        transform.localScale = Vector3.one;

        CleanWillInstallBlock();
        InstallSate state = TryInstallItem();
        if (UIManager.Instance.IsWorldPositionOutOfScreen(transform.position, UIManager.Instance.UICamera) || state == InstallSate.fail)//屏幕外的时候回来
        {
            transform.position = startDragPos;
        }

        img.raycastTarget = true;
        TryShowFloatTween();
        uiBag.ShowItemDes(false);
    }

    private void Update()
    {
        if (isPointerDown)
        {
            touchedTime += Time.deltaTime;
            //按住的缩小
            transform.localScale = Vector3.one * (1 - Math.Clamp(touchedTime,0, pressTime) / pressTime * 0.025f);
        }
        else
        {
            if (isClick) 
            {
                OnClick(touchedTime >= pressTime);
                transform.localScale = Vector3.one;
                isClick = false;
            }
        }

        if (isDraging) 
        {
            if (Input.GetKeyDown(KeyCode.R)) 
            {
                itemData.shape.Rotate();
                transform.Rotate(Vector3.forward, -90);
                CleanWillInstallBlock();
                TryShowWillInstallBlock();
            }
        }
    }

    private void OnClick(bool isLongClick)
    {
        if (isDraging)
            return;
        if (isLongClick)
        {
            //Debug.Log("LongClick!");
        }
        else
        {
            GameManger.Instance.bagCtrl.DealUseableItemClick(itemData);
        }
    }

    private UINSlotItem GetRootSlotItem()
    {
        Vector3[] corners = new Vector3[4];
        foreach (UINSlotItem slotItem in uiBag.slotItemDic.Values)
        {
            if (slotItem != null)
            {
                slotItem.uiTransform.GetWorldCorners(corners);

                var leftDown = UIManager.Instance.World2ScreenPos(corners[0], UIManager.Instance.UICamera);
                var rightUp = UIManager.Instance.World2ScreenPos(corners[2], UIManager.Instance.UICamera);
                var thisPos = UIManager.Instance.World2ScreenPos(transform.position, UIManager.Instance.UICamera);

                float x, y, w, h;
                x = leftDown.x; 
                y = leftDown.y;
                w = rightUp.x - x;
                h = rightUp.y - y;

                Rect rect = new Rect(x, y, w, h);
                if (rect.Contains(thisPos))
                {
                    return slotItem;
                }
            }
        }
        return null;
    }

    /// <summary>
    /// 高亮将会被安装的格子
    /// </summary>
    private void TryShowWillInstallBlock()
    {
        var rootSlotItem = GetRootSlotItem();
        if (rootSlotItem == null)
        {
            return;
        }

        int coordinate = rootSlotItem.coordinate;
        if (privateHoveredCoordinate != null && coordinate == privateHoveredCoordinate.Value) 
        {
            return;
        }
        CleanWillInstallBlock();
        privateHoveredCoordinate = coordinate;

        var shiftArray = itemData.shape.Get2RootShiftArray();
        Vector2Int coordPos = BagCtrl.GetPosFromCoordinate(coordinate);
        foreach (Vector2Int shift in shiftArray)
        {
            var pos = coordPos + shift;
            if (pos.x < 0 || pos.y < 0)
            {
                return;
            }
            int temp_coordinate = BagCtrl.GetCoordinateFromPos(pos);
            if (uiBag.slotItemDic.TryGetValue(temp_coordinate, out UINSlotItem slotItem))
            {
                slotItem.SetIsHoverByItem(true, itemData);
            }
        }
    }

    private void CleanWillInstallBlock()
    {
        privateHoveredCoordinate = null;
        foreach (var slotItemPair in uiBag.slotItemDic)
        {
            slotItemPair.Value.SetIsHoverByItem(false,null);
        }
    }

    private InstallSate TryInstallItem()
    {
        var rootSlotItem = GetRootSlotItem();
        if (rootSlotItem == null)
        {
            //卸载
            bagCtrl.UninstallItem(itemData);
            return InstallSate.notInstall;
        }
        int coordinate = rootSlotItem.coordinate;
        bool isSuccess = bagCtrl.TryInstallItem(itemData, coordinate,out List<ItemBase> popItems);
        if (isSuccess)
        {
            if (popItems != null)
            {
                foreach (var popItem in popItems)
                {
                    uiBag.PopItem2Wait(popItem);
                }
            }
            uiBag.PutItemToBag(this);
            transform.position = rootSlotItem.transform.position;//根部对齐
            return InstallSate.success;
        }
        return InstallSate.fail;
    }

    private enum InstallSate
    {
        success,
        fail,
        notInstall,
    }

    /// <summary>
    /// 未安装的item会悬浮
    /// </summary>
    public void TryShowFloatTween()
    {
        this.transform.DOKill();
        this.transform.localScale = Vector3.one;
        if (itemData.isInstalled)
            return;
        this.transform.DOScale(0.95f,1.0f).SetLoops(-1,LoopType.Yoyo).SetEase(Ease.InOutCubic);
    }
}