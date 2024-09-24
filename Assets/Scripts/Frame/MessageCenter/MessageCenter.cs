using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class MessageCenter
{
    Dictionary<MsgType, List<Action<Object[]>>> listernerDic = new();
    Dictionary<Action, Action<Object[]>> autoConvertActionDic = new();


    //添加监听器
    public void AddListernre(MsgType type, Action<Object[]> action)
    {
        if (!listernerDic.ContainsKey(type))
        {
            listernerDic.Add(type,new List<Action<object[]>>());
        }
        listernerDic[type].Add(action);
    }

    public void AddListernre(MsgType type, Action action)
    {
        if (!autoConvertActionDic.ContainsKey(action))
            autoConvertActionDic.Add(action, (args) => { action?.Invoke(); });
        AddListernre(type, autoConvertActionDic[action]);
    }


    //移除监听器
    public void RemoveListernre(MsgType type, Action<Object[]> action)
    {
        if (!listernerDic.ContainsKey(type))
        {
            return;
        }
        listernerDic[type].Remove(action);
    }

    public void RemoveListernre(MsgType type, Action action)
    {
        if (!autoConvertActionDic.ContainsKey(action))
        {
            return;
        }
        RemoveListernre(type, autoConvertActionDic[action]);
    }


    //广播
    public void BroadCast(MsgType type, Object[] args = null)
    {
        if (!listernerDic.ContainsKey(type))
        {
            return;
        }
        foreach (Action<object[]> action in listernerDic[type])
        {
            action?.Invoke(args);
        }
    }
}

public enum MsgType
{
    onAddWaitItem,//当添加了等待中的物品

    onHeroSwapEnd,//当英雄出生
    onMonsterSwapEnd,//当怪物出生(多个怪物出生完毕后)
    onEnterNewTurn,//当进入新的回合

    onBagItemChange,//当背包物品改变

    onMoveRoom,//当移动到新的房间
}
