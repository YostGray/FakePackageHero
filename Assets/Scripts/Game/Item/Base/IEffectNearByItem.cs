using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 在背包中影响周围物体的物体
/// </summary>
public interface IEffectNearByItem
{
    //影响范围形状
    public ItemShape GetEffectShape();

    public Buff GetEffectBuff();
}
