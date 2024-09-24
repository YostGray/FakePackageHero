using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum BuffDurationType
{
    forever, //永久的
    battleTime, //持续的战斗次数
    turn,//持续的回合
    time,//持续的战斗中触发次数
}

public abstract class Buff
{
    /// <summary>
    /// 持续种类
    /// </summary>
    public BuffDurationType durationType { protected set; get; }
    /// <summary>
    /// 持续次数
    /// </summary>
    public int lastNum { set; get; }

    /// <summary>
    /// Buff的优先级
    /// </summary>
    public int priority { protected set; get; }

    /// <summary>
    /// buff的层数
    /// </summary>
    public int level { protected set; get; }

    /// <summary>
    /// buff动态参数
    /// </summary>
    public Dictionary<String, int> buffDynParam;

    virtual public Color fx_color => Color.Blue;


    /// <summary>
    /// 将buff的影响应用到Buff持有者的物品使用信息上
    /// 物品或背包中生效的Buff都是使用此API的
    /// </summary>
    virtual public void Apply2ItemUseInfo(ItemUseInfo itemUseInfo) { }

    /// <summary>
    /// 将buff的影响应用到Buff持有者的攻击信息上 注意与使用信息内的操作不要重复了
    /// </summary>
    virtual public void Apply2AtkInfo(AttackInfo attackInfo) { }

    /// <summary>
    /// 当被打中
    /// </summary>
    virtual public void OnHurt(AttackInfo attackInfo) { }

    /// <summary>
    /// 当被打中前
    /// </summary>
    virtual public void OnBeforeHurt(AttackInfo attackInfo) { }

    //当buff的level改变
    virtual public void OnBuffLevelChange() { }

    //当回合结束
    virtual public void OnTurnStart() { }

    //当回合结束
    virtual public void OnTurnOver() { }

    //当战斗结束
    virtual public void OnBattleStart() { }

    //当战斗结束
    virtual public void OnBattleOver() { }

    //当buffer被添加给角色
    virtual public void OnBuffAdd2Character(Character character) { }

    //当buff从角色被移除
    virtual public void OnBuff2CharacterRemoved(Character character) { }

    /// <summary>
    /// 合并相同的buff
    /// </summary>
    virtual public void MergeBuff(Buff buff,bool isAdd) { }
    /// <summary>
    /// 合并相同的buff 角色用
    /// </summary>
    virtual public void MergeBuff(Buff buff,bool isAdd, Character character) { }
}