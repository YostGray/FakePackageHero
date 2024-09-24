

using System.Collections.Generic;
/// <summary>
/// 木棍
/// </summary>
public class WoodenStick : ItemBase, IUsableItem
{
    public WoodenStick(ItemCfgData itemCfg) : base(itemCfg)
    {
        
    }

    public void BeUse(ItemUseInfo info)
    {
        info.costInfo = new CostInfo{
            costAp = 2
        };
        info.atkInfo = new AttackInfo{
            attackTag = AttactTagEnum.physic,
            attackShow = AttackShowEnum.close,
            dmgNum = 5,
            caster = info.user,
            targets = info.targets,
        };
        ApplyItemBuff(info);
    }
}
