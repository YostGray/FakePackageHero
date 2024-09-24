using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 永久伤害buff用于物品加强物品上
/// </summary>
public class ItemAddDmgBuff : Buff
{
    public ItemAddDmgBuff(int level) 
    {
        durationType = BuffDurationType.forever;
        this.level = level;
    }

    public override void Apply2ItemUseInfo(ItemUseInfo itemUseInfo)
    {
        if (itemUseInfo?.atkInfo != null) {
            itemUseInfo.atkInfo.dmgNum += level;
        }
    }

    //public override void Apply2AtkInfo(AttackInfo attackInfo)
    //{
    //    attackInfo.dmgNum += level;
    //}

    public override void MergeBuff(Buff buff, bool isAdd)
    {
        if (isAdd)
        {
            this.level += buff.level;
        }
        else
        {
            this.level -= buff.level;
        }
    }
}
