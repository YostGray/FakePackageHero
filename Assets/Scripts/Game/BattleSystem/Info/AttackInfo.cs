using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//发动单次攻击的信息
public class AttackInfo
{
    public Character caster;
    public List<Character> targets;
    public AttactTagEnum attackTag;//对应eAttackTag flag类型枚举
    public AttackShowEnum attackShow;
    public int dmgNum; 
}