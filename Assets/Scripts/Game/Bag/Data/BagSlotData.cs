using UnityEngine;

/// <summary>
/// 背包内的槽位
/// </summary>
public class BagSlotData
{
    public int coordinate {private set; get; }//背包格子所在的位置
    public bool isUnlocked { private set; get; } //是否已解锁
    public ItemBase itemData { private set; get; } //目前包含的物品

    public BagSlotData(int coordinate,bool isUnlock = false)
    {
        this.coordinate = coordinate;
        this.isUnlocked = isUnlock;
    }

    public void SetSlotReferenceItem(ItemBase itemData)
    {
        this.itemData = itemData;
    }

    //public Vector2Int pos
    //{
    //    private set { coordinate = BagManager.GetCoordinateFromPos(value); }
    //    get { return BagManager.GetPosFromCoordinate(coordinate); }
    //} //位置转化为坐标
}