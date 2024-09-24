using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.ComTypes;
using UnityEngine;

[Flags]
public enum eBagState
{
    couldMoveItem = 1,
    couldUseItem = 1 << 1,

    //整理中
    organizeState = couldMoveItem | couldUseItem,
    //战斗中
    battleState = couldUseItem,
}

public class BagCtrl
{
    /// <summary>
    /// 存储slot的字典
    /// 左下为0,0
    /// </summary>
    public Dictionary<int, BagSlotData> slotDic;
    public int col {private set;get; }
    public int row { private set;get; }

    /// <summary>
    /// 背包中存放物品的list
    /// </summary>
    public List<ItemBase> itemList;
    /// <summary>
    /// 等待物品的list
    /// </summary>
    public List<ItemBase> waitItemList;

    /// <summary>
    /// 基于位置生效的buff的list的Dic
    /// </summary>
    private Dictionary<int,List<Buff>> buffListDic;

    public eBagState bagState {  private set;get; }

    public BagCtrl()
    {
        slotDic = new Dictionary<int, BagSlotData>();
        itemList = new List<ItemBase>();
        waitItemList = new List<ItemBase>();
        buffListDic = new Dictionary<int, List<Buff>>();
        bagState = eBagState.organizeState;
    }

    /// <summary>
    /// 初始化槽位字典
    /// </summary>
    /// <param name="col">最大列数</param>
    /// <param name="row">最大行数</param>
    /// <param name="defOpen">默认打开数组</param>
    public void InitSlotDic(int col, int row, List<int> defOpen = null)
    {
        this.col = col;
        this.row = row;
        for (int x = 0; x < col; x++) 
        {
            for (int y = 0; y < row; y++)
            {
                int coor = GetCoordinateFromPos(new Vector2Int(x,y));
                bool? isUnlock = defOpen?.Contains(coor);
                BagSlotData slotData;
                if (isUnlock != null)
                {
                    slotData = new BagSlotData(coor, isUnlock.Value);
                }
                else
                {
                    slotData = new BagSlotData(coor);
                }
                slotDic.Add(coor, slotData);
            }
        }
    }

    // 增加等待物品
    public void AddWaitItem(ItemBase item)
    {
        waitItemList.Add(item);
        GameManger.messageCenter.BroadCast(MsgType.onAddWaitItem);
    }
    public void AddWaitItem(ItemCfgData itemCfg)
    {
        string spriteName = itemCfg.script;

        Type type = GameManger.Instance.gameAssembly.GetType(spriteName);
        object instance = Activator.CreateInstance(type,new object[] { itemCfg });

        if (instance is ItemBase item)
        {
            waitItemList.Add(item);
            GameManger.messageCenter.BroadCast(MsgType.onAddWaitItem);
        }
        else
        {
            Debug.LogError("无法添加物品，请检查反射是否正确，itemId:"+ itemCfg.id);
        }
    }

    //把物品装载到背包
    public bool TryInstallItem(ItemBase itemData, int coordinate, out List<ItemBase> popItems)
    {
        var shiftArray = itemData.shape.Get2RootShiftArray();
        Vector2Int coordPos = GetPosFromCoordinate(coordinate);
        List<BagSlotData> needModifySlotList = new List<BagSlotData>();
        foreach (Vector2Int shift in shiftArray)
        {
            int temp_coordinate = GetCoordinateFromPos(coordPos + shift);
            if (slotDic.TryGetValue(temp_coordinate, out BagSlotData slotData))
            {
                if (slotData == null || !slotData.isUnlocked)
                {
                    popItems = null;
                    return false;
                }
                needModifySlotList.Add(slotData);
            }
        }

        //把自己移除
        if (itemList.Contains(itemData))
        {
            UninstallItem(itemData);
        }

        //改变格子状态
        HashSet<ItemBase> needPopItemSet = new HashSet<ItemBase>();
        foreach (var slotData in needModifySlotList)
        {
            if (slotData.itemData != null)
            {
                if (!needPopItemSet.Contains(slotData.itemData))
                    needPopItemSet.Add(slotData.itemData);
            }
            slotData.SetSlotReferenceItem(itemData);
        }
        foreach (var popItemData in needPopItemSet)
        {
            UninstallItem(popItemData);
            waitItemList.Add(popItemData);
        }

        //维护已安装列表
        if (!itemList.Contains(itemData))
        {
            itemList.Add(itemData);
            itemData.rootPosInBag = GetPosFromCoordinate(coordinate);
            if (waitItemList.Contains(itemData))
            {
                waitItemList.Remove(itemData);
            }
        }

        itemData.OnInstall2Bag(this);

        popItems = needPopItemSet.ToList();
        GameManger.messageCenter.BroadCast(MsgType.onBagItemChange);
        return true;
    }

    //把物品从背包卸载
    public void UninstallItem(ItemBase itemData)
    {
        if (!itemList.Contains(itemData))
        {
            return;
        }
        itemList.Remove(itemData);

        foreach (var slotData in slotDic.Values)
        {
            if (slotData.itemData == itemData)
            {
                slotData.SetSlotReferenceItem(null);
            }
        }

        itemData.OnUninstall2Bag(this);
        itemData.rootPosInBag = new Vector2Int(-1,-1);//卸载还需要它的位置所以最后改

        GameManger.messageCenter.BroadCast(MsgType.onBagItemChange);
    }

    /// <summary>
    /// 修改item上的buff
    /// </summary>
    public void ModifyItemBuff(Buff buff, List<Vector2Int> posList, bool isAdd)
    {
        foreach (Vector2Int p in posList)
        {
            var coordinate = GetCoordinateFromPos(p);
            if (!buffListDic.ContainsKey(coordinate))
            {
                buffListDic.Add(coordinate, new List<Buff>());
            }
            var list = buffListDic[coordinate];
            if (isAdd)
            {
                foreach (var curBuff in list)
                {
                    if (curBuff.GetType() == buff.GetType())
                    {
                        curBuff.MergeBuff(buff, true);
                        return;
                    }
                }
                list.Add(buff);
            }
            else
            {
                foreach (var curBuff in list)
                {
                    if (curBuff.GetType() == buff.GetType())
                    {
                        curBuff.MergeBuff(buff, false);
                        if (curBuff.level <= 0 || curBuff.lastNum <= 0)
                        {
                            list.Remove(curBuff);
                        }
                        break;
                    }
                }
            }
        }
    }

    public static Vector2Int GetPosFromCoordinate(int coordinate)
    {
        return new Vector2Int((int)(coordinate >> 16), (int)(coordinate & 0xFFFF));
    }

    public static int GetCoordinateFromPos(Vector2Int pos)
    {
        if (pos == null || pos.x > Int16.MaxValue || pos.y > Int16.MaxValue || pos.x < 0 || pos.y < 0)
        {
            throw new ArgumentException("not correct coordinate 2 pos convert\n不正确的坐标转换");
        }
        return pos.x << 16 | pos.y;
    }

    public static int GetCoordinateFromPos(int x,int y)
    {
        return GetCoordinateFromPos(new Vector2Int(x, y));
    }

    /// <summary>
    /// 计算item使用信息，显示详情用
    /// 如果以后起冲突了可以把真实的生效和显示的生效分开
    /// </summary>
    public ItemUseInfo CalItemUseInfo(ItemBase itemData)
    {
        var itemUseInfo = GenItemUseInfo(itemData);
        return itemUseInfo;
    }

    //处理item点击
    public void DealUseableItemClick(ItemBase itemData)
    {
        var epCtrl = GameManger.Instance.epCtrl;
        if (!epCtrl.IsInBattle())
            return;

        var itemUseInfo = GenItemUseInfo(itemData);
        if (itemUseInfo.targets.Count() <= 0)
        {
            Debug.Log("道具没有有效的释放目标");
            return;
        }
        if (itemUseInfo?.costInfo != null)
        {
            if (itemUseInfo.costInfo.IsCharacterFitCost(epCtrl.player))
            {
                itemUseInfo.costInfo.DoCharacterCost(epCtrl.player);
            }
            else
            {
                Debug.Log("使用资源不足,无法攻击");
                return;
            }
        }
        epCtrl.battleCtrl.AddItemUseIfon(itemUseInfo);
    }

    private ItemUseInfo GenItemUseInfo(ItemBase itemData)
    {
        if (itemData is IUsableItem)
        {
            ItemUseInfo itemUseInfo = new ItemUseInfo();
            IUsableItem usableItem = (IUsableItem)itemData;

            var epCtrl = GameManger.Instance.epCtrl;

            if (epCtrl.IsInBattle())
            {
                itemUseInfo.user = epCtrl.player;
                itemUseInfo.targets = new List<Character>();
                if (epCtrl?.battleCtrl?.selectedCharacter != null)
                {
                    itemUseInfo.targets.Add(epCtrl.battleCtrl.selectedCharacter);
                }
                usableItem.BeUse(itemUseInfo);

                List<Vector2Int> posList = itemData.GetBlocks4Shape();
                if (posList != null)
                {
                    foreach (Vector2Int pos in posList)
                    {
                        int coor = GetCoordinateFromPos(pos);
                        if (buffListDic.TryGetValue(coor, out var buffList))
                        {
                            foreach (Buff buff in buffList)
                            {
                                buff.Apply2ItemUseInfo(itemUseInfo);
                            }
                        }
                    }
                }

                epCtrl.player.OnUseItem(itemUseInfo);

                if (itemUseInfo.atkInfo != null)
                {
                    epCtrl.player.OnAttack(itemUseInfo.atkInfo);
                }
            }
            else
            {
                itemUseInfo.user = epCtrl.player;
                itemUseInfo.targets = null;
                usableItem.BeUse(itemUseInfo);
                //TODO 局外使用物品
            }
            return itemUseInfo;
        }
        return null;
    }

    public bool IsCouldMoveItem()
    {
        return (bagState & eBagState.couldMoveItem) > 0;
    }
    public void EnterSelectItemState()
    {
        var ui_bag = UIManager.Instance.GetWindow<UIBag>("UI_Bag");
        ui_bag.EnterWaitAddItemState();
    }

    public void LeaveSelectItemState()
    {
        waitItemList.Clear();
        var ui_bag = UIManager.Instance.GetWindow<UIBag>("UI_Bag");
        ui_bag.FinishWaitAddItemState();
    }

    public void ChangeBagState(eBagState newState, bool isAdd)
    {
        if (isAdd && !bagState.HasFlag(newState))//添加状态
        {
            bagState |= newState;
            switch (newState)
            {
                case eBagState.couldMoveItem:
                    break;
                case eBagState.couldUseItem:
                    break;
            }
        }
        else if (!isAdd && bagState.HasFlag(newState))
        {
            bagState &= ~newState;
            switch (newState)
            {
                case eBagState.couldMoveItem:
                    break;
                case eBagState.couldUseItem:
                    break;
            }
        }
    }
    public void OnBattleStart()
    {
        foreach (var item in itemList)
        {
            item.OnBattleStart();
        }
    }
    public void OnBattleEnd()
    {
        foreach (var item in itemList)
        {
            if (item is IEffectNearByItemWhenBattleEnd itemEnd)
            {
                var effectShape = itemEnd.GetEffectShape();
                var posList = item.GetBlocks4Shape(effectShape);
                HashSet<ItemBase> itemSet = new HashSet<ItemBase>();
                if (posList != null)
                {
                    foreach (Vector2Int pos in posList)
                    {
                        int coor = GetCoordinateFromPos(pos);
                        if (slotDic.TryGetValue(coor, out BagSlotData slotData))
                        {
                            if (slotData != null && slotData.isUnlocked 
                                && slotData.itemData != null && !itemSet.Contains(slotData.itemData))
                            {
                                itemSet.Add(slotData.itemData);
                            }
                        }
                    }
                }
                itemEnd.AddBuff2ItemList(itemSet.ToList());
            }
        }
        var tempItemList = new List<ItemBase>(itemList);
        foreach (var item in tempItemList)
        {
            item.OnBattleEnd();
        }
    }
}