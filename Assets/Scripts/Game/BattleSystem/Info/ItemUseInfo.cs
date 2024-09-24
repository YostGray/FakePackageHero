using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//物品使用的信息
public class ItemUseInfo
{
    /// <summary>
    /// 发起者 实际结算使用AttackInfo内部的数据
    /// </summary>
    public Character user { set; get; }
    /// <summary>
    /// 被使用对象 实际结算使用addBuffInfo内部的数据
    /// </summary>
    public List<Character> targets = new();

    /// <summary>
    /// 发起者的消耗信息
    /// </summary>
    public CostInfo costInfo { set; get; }

    /// <summary>
    /// 附带的攻击信息
    /// </summary>
    public AttackInfo atkInfo { set; get; }

    /// <summary>
    /// 对目标需要添加的Buff信息
    /// </summary>
    public AddBuffInfo addBuffInfo { set; get; }
}