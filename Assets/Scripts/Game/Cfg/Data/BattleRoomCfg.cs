using Newtonsoft.Json;
using System;
using System.Collections.Generic;


//背包初始化配置
public class BattleRoomCfg : ICfg
{
    public static Dictionary<int, BattleRoomCfgData> data;

    public Type GetDataType()
    {
        return typeof(Dictionary<int, BattleRoomCfgData>);
    }

    public void FillData(object o)
    {
        data = (Dictionary<int, BattleRoomCfgData>)o;
    }

    public void LoadOverDeal() { }
}

public class BattleRoomCfgData
{
    [JsonProperty]
    public int id { private set; get; }
    [JsonProperty]
    public int[] monsters { private set; get; }
    [JsonProperty]
    public bool is_elite { private set; get; }
    [JsonProperty]
    public int[] loot_list { private set; get; }
    [JsonProperty]
    public int loot_num { private set; get; }
}
