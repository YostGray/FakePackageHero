using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static UnityEngine.GraphicsBuffer;

namespace Game.EnemyAI
{
    public class EnemyAI_TreeTrunkMushroom : EnemyAIBase
    {
        public override EnemyIntention GenEnemyIntention()
        {
            EnemyIntention intention;
            int r = AIRandom.Next(100);//0-99
            if (r < 33)//atk 8
            {
                var atk = new AttackInfo
                {
                    attackTag = AttactTagEnum.physic,
                    attackShow = AttackShowEnum.close,
                    dmgNum = 8,
                    caster = self,
                    targets = GetPlayerAsList(),
                };
                intention = new EnemyIntention(IntentionEnum.Attack, atk);
            }
            else if (r < 66)//atk 5x2
            {
                var once = new AttackInfo{
                    attackTag = AttactTagEnum.physic,
                    attackShow = AttackShowEnum.close,
                    dmgNum = 5,
                    caster = self,
                    targets = GetPlayerAsList(),
                };
                intention = new EnemyIntention(IntentionEnum.Attack, once,2);
            }
            else//add 2层愤怒 buff
            {
                intention = new EnemyIntention(IntentionEnum.AddBuff, new List<AddBuffInfo>{
                    new AddBuffInfo{
                        buff = new AngerBuff(2),
                        caster = self,
                        targets = GetPlayerAsList(),
                    }
                }) ;
            }
            return intention;
        }
    }
}