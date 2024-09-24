
using System.Collections.Generic;
/// <summary>
/// 敌人意图
/// </summary>
public class EnemyIntention
{
    public IntentionEnum intrntionType { private set; get; }
    public List<AddBuffInfo> addBuffInfos { private set; get; }
    public List<AttackInfo> attackInfos { private set; get; }

    public EnemyIntention(IntentionEnum type, List<AddBuffInfo> addBuffInfos)
    {
        intrntionType = type;
        this.addBuffInfos = addBuffInfos;
    }

    public EnemyIntention(IntentionEnum type, AttackInfo attackInfo)
    {
        intrntionType = type;
        attackInfos = new List<AttackInfo>() { attackInfo };
    }

    public EnemyIntention(IntentionEnum type, AttackInfo attackInfo,int attackTimes)
    {
        intrntionType = type;
        attackInfos = new List<AttackInfo>();
        for (int i = 0; i < attackTimes; i++)
        {
            attackInfos.Add(attackInfo);
        }
    }
}

public enum IntentionEnum
{
    Attack = 1,
    AddBuff = 2,
    AddDebuff = 3,
}
