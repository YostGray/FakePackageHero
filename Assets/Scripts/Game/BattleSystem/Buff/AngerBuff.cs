using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 愤怒buff每层增加1点伤害
/// </summary>
public class AngerBuff : Buff
{
    public override Color fx_color => Color.Red;

    public AngerBuff(int lastNum) 
    {
        durationType = BuffDurationType.turn;
        this.lastNum = lastNum;
        this.level = lastNum;
    }

    public override void OnTurnOver()
    {
        lastNum -= 1;
        level = lastNum;
    }

    public override void Apply2AtkInfo(AttackInfo attackInfo)
    {
        attackInfo.dmgNum += level;
    }

    public override void MergeBuff(Buff buff, bool isAdd)
    {
        if (isAdd)
        {
            this.lastNum += buff.lastNum;
            this.level += buff.level;
        } 
        else
        {
            this.lastNum -= buff.lastNum;
            this.level -= buff.level;
        }
    }
}
