using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

//角色
public class Character
{
    #region 角色数据
    public bool isAlive { protected set; get; } = true;

    //血量
    protected CharacterAttribute HP;
    //魔力
    protected CharacterAttribute MP;
    //行动力
    protected CharacterAttribute AP;

    //人物拥有的buff列表
    protected List<Buff> buffList = new List<Buff>();

    public int curHp => HP.curValue;
    public int curMp => MP.curValue;
    public int curAp => AP.curValue;

    public int maxHp => HP.defaultValue;
    public int maxMp => MP.defaultValue;
    public int maxAp => AP.defaultValue;

    public string resName { get; protected set; }
    /// <summary>
    /// 场景里的横向占位大小(单位是unity单位=1像素)
    /// </summary>
    public float sizeInScene { get; protected set; }
    private CharacterEntity _entity;
    public CharacterEntity entity { 
        get { return _entity; } 
        set { _entity = value; _entity.character = this; } 
    }    
    #endregion

    #region 角色行为

    //改变HP时
    public void ChangeHp(int num)
    {
        HP.curValue += num;
        if (HP.curValue <= 0)
            Dead();
    }

    //改变HP最大值时
    public void ChangeMaxHp(int num)
    {
        HP.defaultValue += num;
        if (HP.curValue > HP.defaultValue)
        {
            HP.curValue = HP.defaultValue;
        }
        if (HP.curValue <= 0)
            Dead();
    }

    //改变MP时
    public void ChangeMp(int num)
    {
        MP.curValue += num;
        Math.Clamp(MP.curValue, 0, MP.defaultValue);
    }

    //改变AP时
    public void ChangeAp(int num)
    {
        AP.curValue += num;
    }

    //死了
    public void Dead()
    {
        isAlive = false;
        OnDead();
    }
    #endregion

    #region 角色触发点
    //当死了
    public void OnDead()
    {

    }

    //进入战斗时
    public void OnEnterBattle()
    {

    }

    //使用背包物品时,在物品效果真的触发前调用
    public void OnUseItem(ItemUseInfo itemUseInfo)
    {
        //应用Buff
        for (int i = 0; i < buffList.Count; i++)
        {
            buffList[i].Apply2ItemUseInfo(itemUseInfo);
        }
    }

    //当攻击时
    public void OnAttack(AttackInfo attackInfo)
    {
        //应用Buff
        for (int i = 0; i < buffList.Count; i++)
        {
            buffList[i].Apply2AtkInfo(attackInfo);
        }
    }

    //被攻击时
    public void BeAttack(AttackInfo attackInfo)
    {
        for (int i = 0; i < buffList.Count; i++)
        {
            buffList[i].OnBeforeHurt(attackInfo);
        }
        ChangeHp(-attackInfo.dmgNum);
        for (int i = 0; i < buffList.Count; i++)
        {
            buffList[i].OnHurt(attackInfo);
        }
    }

    public void AddBuff(Buff buff)
    {
        foreach (var curBuff in buffList)
        {
            if (curBuff.GetType() == buff.GetType())
            {
                curBuff.MergeBuff(buff,true,this);
                return;
            }
        }
        buff.OnBuffAdd2Character(this);
        buffList.Add(buff);
    }

    //被添加Buff时
    public void BeAddBuff(AddBuffInfo addBuffInfo)
    {
        AddBuff(addBuffInfo.buff);
    }

    public void RemoveBuff(Buff buff)
    {
        foreach (var curBuff in buffList)
        {
            if (curBuff.GetType() == buff.GetType())
            {
                curBuff.MergeBuff(buff,false,this);
                if (curBuff.level <= 0 || curBuff.lastNum <= 0)
                {
                    curBuff.OnBuff2CharacterRemoved(this);
                    buffList.Remove(curBuff);
                }
                return;
            }
        }
    }

    #endregion

    /// <summary>
    /// 当新的回合开始
    /// </summary>
    public virtual void OnTurnStart()
    {

    }

    /// <summary>
    /// 当回合结束时
    /// </summary>
    public virtual void PlayerTurnOver() 
    {
        
    }
}

//角色属性
public struct CharacterAttribute
{
    /// <summary>
    /// 属性默认值 
    /// 也可以理解成最大值？后续可能要考虑buff什么的
    /// </summary>
    public int defaultValue;
    /// <summary>
    /// 属性当前值
    /// 当受影响偏离默认值时使用
    /// </summary>
    public int curValue;

    public CharacterAttribute(int num)
    {
        defaultValue = num;
        curValue = num;
    }
}