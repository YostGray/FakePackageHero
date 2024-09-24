using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 在战斗结束时影响背包中周围物体的物体
/// </summary>
public interface IEffectNearByItemWhenBattleEnd
{
    //影响范围形状
    public ItemShape GetEffectShape();
    //对物体添加影响
    public void AddBuff2ItemList(List<ItemBase> items);
}
