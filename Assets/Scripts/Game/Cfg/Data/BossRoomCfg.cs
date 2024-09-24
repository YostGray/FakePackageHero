using Newtonsoft.Json;
using System;
using System.Collections.Generic;


//背包初始化配置
public class BossRoomCfg : ICfg
{
    public static Dictionary<int, BossRoomCfgData> data;

    public Type GetDataType()
    {
        return typeof(Dictionary<int, BossRoomCfgData>);
    }

    public void FillData(object o)
    {
        data = (Dictionary<int, BossRoomCfgData>)o;
    }

    public void LoadOverDeal() { }
}

public class BossRoomCfgData
{
    [JsonProperty]
    public int id { private set; get; }
    [JsonProperty]
    public int[] monsters { private set; get; }
    [JsonProperty]
    public int[] loot_list { private set; get; }
    [JsonProperty]
    public int loot_num { private set; get; }
}
