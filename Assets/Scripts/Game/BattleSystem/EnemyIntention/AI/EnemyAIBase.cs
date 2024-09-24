using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Game.EnemyAI
{
    public abstract class EnemyAIBase
    {
        protected EnemyCharacter self;

        protected System.Random AIRandom => GameManger.Instance.epCtrl.battleCtrl.battleRandom;

        public abstract EnemyIntention GenEnemyIntention();

        public virtual void BindCharacter(EnemyCharacter enemyCharacter)
        {
            self = enemyCharacter;
        }

        protected static List<Character> GetPlayerAsList()
        {
            return new List<Character>() { GameManger.Instance.epCtrl.battleCtrl.player };
        }
    }
}
