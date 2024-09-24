using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//���ѵ���Ϣ
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
    /// ��ɫ�Ƿ����㻨��
    /// </summary>
    public bool IsCharacterFitCost(Character c)
    {
        if (c.curAp < costAp)
            return false;
        if (c.curMp < costMp)
            return false;
        //��Ѫ����飬ֱ����
        //if (c.curHp < costHp)
        //    return false;
        return true;
    }

    /// <summary>
    /// ���л���
    /// </summary>
    public void DoCharacterCost(Character c)
    {
        c.ChangeHp(-costHp);
        c.ChangeMp(-costMp);
        c.ChangeAp(-costAp);
    }
}