using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Game.UI.BattleInfoUI
{
    public class UINCharacterInfoBase : UIBase
    {
        public RectTransform selfRect { private set; get; }
        private bool isInited = false;

        [SerializeField]
        private Image hpImage;
        [SerializeField]
        private Text hpText;

        protected Character character;
        protected ResLoader resLoader;

        public virtual void Init()
        {
            if(isInited)
                return;
            isInited = true;
            selfRect = this.GetComponent<RectTransform>();
        }

        public virtual void BindCharacter(Character character)
        { 
            this.character = character;
            Refresh();
        }

        public void InitResLoader(ResLoader resLoader)
        {
            this.resLoader = resLoader;
        }

        public virtual void Refresh() 
        {
            int hp = Mathf.Clamp(character.curHp,0,int.MaxValue);

            hpText.text = $"{hp}/{character.maxHp}";
            hpImage.fillAmount = ((float)hp) / character.maxHp;

            if(hp <= 0)
            {
                Hide();
            }
        }
    }
}