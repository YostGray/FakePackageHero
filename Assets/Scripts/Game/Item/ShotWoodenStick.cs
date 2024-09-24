

using System.Collections.Generic;
/// <summary>
/// 短木棍
/// </summary>
public class ShotWoodenStick : ItemBase, IUsableItem
{
    public ShotWoodenStick(ItemCfgData itemCfg) : base(itemCfg)
    {
        
    }

    public void BeUse(ItemUseInfo info)
    {
        info.costInfo = new CostInfo { 
            costAp = 1
        };
        info.atkInfo = new AttackInfo {
            attackTag = AttactTagEnum.physic,
            attackShow = AttackShowEnum.close,
            dmgNum = 2,
            caster = info.user,
            targets = info.targets,
        };
    }
}