using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//花费的信息
public class CostInfo
{
    public int costAp {  get; set; }
    public int costMp {  get; set; }
    public int costHp {  get; set; }

    public CostInfo()
    {
        costAp = 0;
        costMp = 0;
        costHp = 0;
    }

    /// <summary>
    /// 角色是否满足花费
    /// </summary>
    public bool IsCharacterFitCost(Character c)
    {
        if (c.curAp < costAp)
            return false;
        if (c.curMp < costMp)
            return false;
        //扣血不检查，直接死
        //if (c.curHp < costHp)
        //    return false;
        return true;
    }

    /// <summary>
    /// 进行花费
    /// </summary>
    public void DoCharacterCost(Character c)
    {
        c.ChangeHp(-costHp);
        c.ChangeMp(-costMp);
        c.ChangeAp(-costAp);
    }
}