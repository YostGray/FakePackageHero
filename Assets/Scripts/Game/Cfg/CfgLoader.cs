using System;
using System.Collections.Generic;
using UnityEngine;

public static class CfgLoader
{
    private static readonly Dictionary<string, ICfg> cfgLoadDic = new Dictionary<string, ICfg> {
        { "bag_init_state",new BagInitStateCfg()},
        { "item",new ItemCfg()},
        { "hero",new HeroCfg()},
        { "enemy",new EnemyCfg()},
        { "tag",new TagCfg()},
        { "tagGroup",new TagGroupCfg()},

        { "ep",new EpCfg()},
        { "stage",new StageCfg()},
        { "battleRoom",new BattleRoomCfg()},
        { "bossRoom",new BossRoomCfg()},
        { "loot",new LootCfg()},
    };

    public static void ReadAllJson()
    {
        ResLoader jsonReader = ResLoadManager.GetResLoader();

        foreach (var cfgDef in cfgLoadDic)
        {
            string loadPath = PathHelper.GetJsonCfgPath(cfgDef.Key);
            TextAsset jsonString = jsonReader.Load<TextAsset>(loadPath);

            ICfg cfg = cfgDef.Value;
            Type valueType = cfg.GetDataType();
            object cfgData = JsonUtil.DeserializeJson(valueType, jsonString.text);
            cfg.FillData(cfgData);
            cfg.LoadOverDeal();
        }
    }
}