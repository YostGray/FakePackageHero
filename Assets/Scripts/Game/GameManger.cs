using Assets.Scripts.Game.UI.BattleInfoUI;
using System;
using System.Collections;
using System.Linq;
using System.Reflection;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Manger是单例 controller实例
/// </summary>
public class GameManger : SingletonMono<GameManger>
{
    public static MessageCenter messageCenter;
    public EpCtrl epCtrl;
    public BagCtrl bagCtrl;

    public Assembly gameAssembly;

    public int seed = 1145141919;//DateTime.Now.Second
    public int mapSeed => seed + 1;//后续可以扩展成算法

    // Use this for initialization
    void Start()
    {
        CfgLoader.ReadAllJson();
        TagRegister.RegistAllTag();
        TagGroupRegister.RegistAllTagGroup();
        messageCenter = new MessageCenter();

        Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
        gameAssembly = assemblies.FirstOrDefault(a => a.GetName().Name == "Game");
        if (gameAssembly == null)
            Debug.LogError("无法获取Game程序集");

        MonoDriver.Instance.StartCoroutine(TestInit());
    }

    //测试用↓
    IEnumerator TestInit()
    {
        bool isEpLoadOver = false;

        //加载1号探索
        EpCfgData epCfg = EpCfg.data[1];
        EpCtrl.EnterNewEp(epCfg, (epCtrl) => {
            this.epCtrl = epCtrl;
            isEpLoadOver = true;
        });

        while (!isEpLoadOver)
            yield return null;

        //初始化背包
        BagInitStateCfg.data.TryGetValue(1, out BagInitStateData data);
        bagCtrl = new BagCtrl();
        bagCtrl.InitSlotDic(data.max_szie[0], data.max_szie[1], data.GetDefaultOpenList());

        var ui_bag = UIManager.Instance.LoadWindow<UIBag>("UI_Bag");
        ui_bag.InitUIBag();
        var ui_battleInfo = UIManager.Instance.ShowOrLoadWindow<UIBattleInfo>("UI_BattleInfo");
        ui_battleInfo.InitUIBattleInfo();

        bagCtrl.AddWaitItem(new ShotWoodenStick(ItemCfg.data[1]));
        bagCtrl.AddWaitItem(new WoodenStick(ItemCfg.data[2]));
        bagCtrl.AddWaitItem(new GreenGem(ItemCfg.data[3]));
        bagCtrl.AddWaitItem(new PlainRing(ItemCfg.data[4]));

        epCtrl.ChangeEpState(eEpState.waitAddItem2Bag);
    }
}