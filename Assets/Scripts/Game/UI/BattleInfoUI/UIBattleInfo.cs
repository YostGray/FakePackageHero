using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Game.UI.BattleInfoUI
{
    public class UIBattleInfo : UIBase
    {
        [SerializeField]
        private UINHeroInfo heroInfo;
        [SerializeField]
        private GameObject monsterInfoPrototype;
        [SerializeField]
        private RectTransform selectedNode;

        private EpCtrl epCtrl;
        private ObjectPool monsterInfoPool;
        private RectTransform selfRect;
        private ResLoader resLoader;


        public override void Awake()
        {
            resLoader = ResLoadManager.GetResLoader();
            heroInfo.Init();
            heroInfo.InitResLoader(resLoader);
            heroInfo.gameObject.SetActive(false);
            monsterInfoPool = new ObjectPool(monsterInfoPrototype);
            selfRect = this.GetComponent<RectTransform>();
            selectedNode.gameObject.SetActive(false);

            base.Awake();
        }

        internal void InitUIBattleInfo()
        {
            epCtrl = GameManger.Instance.epCtrl;
            GameManger.messageCenter.AddListernre(MsgType.onHeroSwapEnd, RefreshHeroInfo);
            GameManger.messageCenter.AddListernre(MsgType.onMonsterSwapEnd, RefreshAllMonsterInfo);
            GameManger.messageCenter.AddListernre(MsgType.onBagItemChange, OnBattleLogicUpdate);
            GameManger.messageCenter.AddListernre(MsgType.onEnterNewTurn, OnEnterNewTurn);
            RefreshHeroInfo();
        }

        public void OnBattleLogicUpdate()
        {
            RefreshHeroValue();
            RefreshAllMonsterValue();
            RefreshSelectedMonser();
        }

        public void RefreshHeroInfo()
        {
            Character hero = epCtrl.player;
            CharacterEntity entity = hero.entity;
            UIManager.Instance.World2UIPos(entity.infoHolder.transform.position, selfRect, out Vector2 pos);
            heroInfo.gameObject.SetActive(true);
            heroInfo.selfRect.localPosition = pos;
            heroInfo.BindCharacter(hero);
        }

        public void RefreshHeroValue()
        {
            Character hero = epCtrl.player;
            heroInfo.Refresh();
        }

        public void RefreshAllMonsterInfo()
        {
            monsterInfoPool.RecycleAll();
            List<Character> enemyList = epCtrl?.battleCtrl?.enemyList;
            if (enemyList == null)
                return;

            foreach (Character enemy in enemyList)
            {
                GameObject go = monsterInfoPool.GetOne();
                UINEnemyInfo enemyInfo = go.GetComponent<UINEnemyInfo>();
                enemyInfo.Init();
                enemyInfo.InitResLoader(resLoader);

                CharacterEntity entity = enemy.entity;
                UIManager.Instance.World2UIPos(entity.infoHolder.transform.position, selfRect, out Vector2 pos);
                enemyInfo.gameObject.SetActive(true);
                enemyInfo.selfRect.localPosition = pos;
                enemyInfo.BindCharacter(enemy);
            }
        }

        public void RefreshAllMonsterValue()
        {
            foreach (GameObject enemyInfo in monsterInfoPool.livingList)
            {
                enemyInfo.GetComponent<UINEnemyInfo>().Refresh();
            }
        }

        public void RefreshSelectedMonser()
        {
            if (!epCtrl.IsInBattle())
            { 
                selectedNode.gameObject.SetActive(false);
                return; 
            }
            Character selectedCharacter = epCtrl.battleCtrl?.selectedCharacter;
            if (selectedCharacter == null)
            {
                selectedNode.gameObject.SetActive(false);
                return;
            }
            Vector3 cPos = selectedCharacter.entity.transform.position;
            var enemyCharacter = (EnemyCharacter)selectedCharacter;
            cPos = new Vector3(cPos.x + enemyCharacter.enemyCenterOffset.x, cPos.y + enemyCharacter.enemyCenterOffset.y, cPos.z);
            UIManager.Instance.World2UIPos(cPos, selfRect, out Vector2 pos);
            selectedNode.localPosition = pos;
            selectedNode.gameObject.SetActive(true);
        }

        private void OnEnterNewTurn()
        {
            OnBattleLogicUpdate();
        }

        private void OnDestroy()
        {
            GameManger.messageCenter.RemoveListernre(MsgType.onHeroSwapEnd, RefreshHeroInfo);
            GameManger.messageCenter.RemoveListernre(MsgType.onMonsterSwapEnd, RefreshAllMonsterInfo);
            GameManger.messageCenter.RemoveListernre(MsgType.onBagItemChange, OnBattleLogicUpdate);
            GameManger.messageCenter.RemoveListernre(MsgType.onEnterNewTurn, OnBattleLogicUpdate);

            ResLoadManager.RecycleResLoader(resLoader);
        }
    }
}