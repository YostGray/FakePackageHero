using Assets.Scripts.Game.UI.BattleInfoUI;
using Codice.Client.BaseCommands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// 探索地图控制器
/// </summary>
public class EpCtrl
{
    /// <summary>
    /// 探索状态：是标志位
    /// </summary>
    eEpState epState = eEpState.none;

    public EpMap epMap { private set; get; }
    ResLoader resLoader;
    BattleScene battleScene;

    public Character player { private set; get; }
    public BattleCtrl battleCtrl;

    public static void EnterNewEp(EpCfgData epCfg, Action<EpCtrl> callback)
    {
        string sceneStr = epCfg.scene_name;
        //加载场景
        MySceneManager.Instance.LoadABAsync(sceneStr, (_) => {
            BattleScene battleScene = UnityEngine.Object.FindAnyObjectByType<BattleScene>();
            var epCtrl = new EpCtrl(battleScene, epCfg, HeroCfg.data[1]);
            callback?.Invoke(epCtrl);
        });
    }

    public EpCtrl(BattleScene battleScene,EpCfgData epCfg,HeroCfgData heroCfg)
    {
        this.battleScene = battleScene;
        resLoader = ResLoadManager.GetResLoader();

        //默认初始化第一个stage
        var stageCfgData = StageCfg.data[epCfg.stage_list[0]];
        epMap = new EpMap(stageCfgData);

        //初始化玩家角色
        SwapNewPlayerEntity(heroCfg);
        //进入初始化房间
        epMap.EnterRoom(epMap.curRoom);
    }

    //创建新的玩家实体
    public void SwapNewPlayerEntity(HeroCfgData heroCfg)
    {
        player = new HeroCharacter(heroCfg);
        resLoader.LoadAsync(PathHelper.GetCharacterPrefabPath(player.resName), (GameObject o) => {
            var go = GameObject.Instantiate(o,battleScene.heroHolder.transform);
            player.entity = go.GetComponent<CharacterEntity>();
            GameManger.messageCenter.BroadCast(MsgType.onHeroSwapEnd);
        });
    }

    //创建新的敌人实体
    public void SwapNewEmemyEntity(Character character, Vector3 offset,Action callback)
    {
        resLoader.LoadAsync(PathHelper.GetMonsterPrefabPath(character.resName), (GameObject o) => {
            var go = GameObject.Instantiate(o, battleScene.enemyHolder.transform);
            go.transform.localScale = new Vector3(1,1,1);
            go.transform.localPosition = offset;
            character.entity = go.GetComponent<CharacterEntity>();
            callback?.Invoke();
        });
    }

    /// <summary>
    /// 探索状态改变 约定下只能由房间改变 不深入到具体玩法控制器中
    /// </summary>
    public void ChangeEpState(eEpState newState)
    {
        if (epState == newState)
        {
            return;
        }
        //处理退出旧状态
        switch (epState)
        {
            case eEpState.exploring:
                break;
            case eEpState.inBattle:
                GameManger.Instance.bagCtrl.ChangeBagState(eBagState.couldMoveItem, true);
                GameManger.Instance.bagCtrl.OnBattleEnd();
                break;
            case eEpState.waitAddItem2Bag:
                GameManger.Instance.bagCtrl.LeaveSelectItemState();
                break;
            default:
                break;
        }
        epState = newState;
        switch (newState)
        {
            case eEpState.exploring:
                break;
            case eEpState.inBattle:
                GameManger.Instance.bagCtrl.ChangeBagState(eBagState.couldMoveItem, false);
                GameManger.Instance.bagCtrl.OnBattleStart();
                break;
            case eEpState.waitAddItem2Bag:
                GameManger.Instance.bagCtrl.EnterSelectItemState();
                break;
            default:
                break;
        }
    }

    public bool IsInBattle()
    {
        return epState == eEpState.inBattle;
    }
}
