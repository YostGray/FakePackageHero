using System;
using UnityEngine;

public abstract class EpRoom
{
    public Vector2Int Pos { get; set; }
    public eEpRoomLogicType RoomType { protected set; get; }


    public abstract void BeEnter();
    public abstract void BeLeave();
    public abstract string GetLevelItemResName();
}
