using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 加血上限的buffer
/// </summary>
public class ItemAddMaxHPBuff : Buff
{
    public ItemAddMaxHPBuff(int level) 
    {
        durationType = BuffDurationType.forever;
        this.level = level;
    }

    public override void OnBuffAdd2Character(Character character)
    {
        character.ChangeMaxHp(level);
    }

    public override void OnBuff2CharacterRemoved(Character character)
    {
        character.ChangeMaxHp(-level);
    }

    public override void MergeBuff(Buff buff, bool isAdd, Character character)
    {
        if (isAdd)
        {
            level += buff.level;
            character.ChangeMaxHp(buff.level);
        }
        else
        {
            var minLevel = -Math.Max(buff.level, level);
            level += minLevel;
            character.ChangeMaxHp(minLevel);
        }
    }
}
