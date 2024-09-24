using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeBlock
{
    bool isRoot;
    /// <summary>
    /// 相对Root的位置
    /// </summary>
    public int coordinate { private set; get; }
    /// <summary>
    /// 相对Root的位置转化为坐标
    /// </summary>
    public Vector2Int pos
    {
        private set { coordinate = BagCtrl.GetCoordinateFromPos(value); }
        get { return BagCtrl.GetPosFromCoordinate(coordinate); }
    } 
}