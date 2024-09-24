using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Game.UI.BattleInfoUI
{
    public class UINHeroInfo : UINCharacterInfoBase
    {
        private ObjectPool apEmptyPool;
        private ObjectPool apFullPool;

        [SerializeField]
        private GameObject apEmptyPrototype;
        [SerializeField]
        private GameObject apFullPrototype;


        public override void Init()
        {
            base.Init();

            apEmptyPool = new ObjectPool(apEmptyPrototype);
            apFullPool = new ObjectPool(apFullPrototype);
        }

        public override void Refresh() 
        {
            base.Refresh();

            apEmptyPool.RecycleAll();
            apFullPool.RecycleAll();

            for (int i = 0; i < character.maxAp; i++)
            {
                if (character.curAp > i)
                {
                    apFullPool.GetOne();
                }
                else 
                {
                    apEmptyPool.GetOne();
                }
            }
        }
    }
}