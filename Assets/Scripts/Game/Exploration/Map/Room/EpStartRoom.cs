using System.Collections.Generic;
using System.Linq;
using UnityEngine;

/// <summary>
/// 每层的起始房间
/// </summary>
public class EpStartRoom : EpRoom
{
    public EpStartRoom()
    {
        RoomType = eEpRoomLogicType.empty;
    }

    public override void BeEnter()
    {

    }

    public override void BeLeave()
    {

    }

    public override string GetLevelItemResName()
    {
        return "房间_空房间";
    }
}