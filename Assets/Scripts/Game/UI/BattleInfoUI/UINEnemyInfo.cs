using System.Collections;
using System.Linq;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.UI;

namespace Assets.Scripts.Game.UI.BattleInfoUI
{
    public class UINEnemyInfo : UINCharacterInfoBase
    {
        [SerializeField]
        private Text intentionText;
        [SerializeField]
        private Image intentionBg;

        public override void Refresh()
        {
            base.Refresh();
            EnemyCharacter enemyCharacter = (EnemyCharacter)character;
            if (enemyCharacter.enemyIntention != null)
            {
                switch (enemyCharacter.enemyIntention.intrntionType)
                {
                    case IntentionEnum.Attack:
                        intentionBg.sprite = LoadImg("sword");
                        intentionText.gameObject.SetActive(true);
                        int atkTimes = enemyCharacter.enemyIntention.attackInfos.Count;
                        int atkDmg = enemyCharacter.enemyIntention.attackInfos.First().dmgNum;
                        if (atkTimes == 1)
                        {
                            intentionText.text = atkDmg.ToString();
                        }
                        else
                        {
                            intentionText.text = string.Format("{0}x{1}",atkDmg.ToString(),atkTimes.ToString());
                        }
                        intentionText.color = Color.red;
                        break;
                    case IntentionEnum.AddBuff:
                        intentionBg.sprite = LoadImg("heart");
                        intentionText.gameObject.SetActive(false);
                        break;
                    case IntentionEnum.AddDebuff:
                        intentionBg.sprite = LoadImg("warning");
                        intentionText.gameObject.SetActive(false);
                        break;
                }
            }
        }

        private Sprite LoadImg(string resName) 
        {
            SpriteAtlas itemAtlas = resLoader.Load<SpriteAtlas>(PathHelper.GetAtlasePath("UIBattleInfo"));
            return itemAtlas.GetSprite(resName);
        }
    }
}