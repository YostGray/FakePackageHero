using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 可以主动使用的物体
/// </summary>
public interface IUsableItem
{
    public void BeUse(ItemUseInfo itemUseInfo);
}
