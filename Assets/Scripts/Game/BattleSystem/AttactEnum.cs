using System;

/// <summary>
/// 攻击的逻辑种类枚举
/// </summary>
[Flags]
public enum AttactTagEnum
{
    physic = 0,//物理攻击
    magic = 1,//魔法攻击
    heal = 2,//治疗(特殊的攻击类型)
    counterattack = 4,//是反击类型
}


/// <summary>
/// 攻击的表现种类枚举
/// </summary>
public enum AttackShowEnum
{
    none = 0,
    close = 1,
    remote = 2,//也许可以再细分？
}