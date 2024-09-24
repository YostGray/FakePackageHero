using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 在背包中给角色加Buff的物体
/// </summary>
public interface IInBagAddBuffItem
{
    public Buff GetEffectBuff();
}
