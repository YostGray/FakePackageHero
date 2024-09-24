using Newtonsoft.Json;
using System;
using System.Collections.Generic;


//背包初始化配置
public class StageCfg : ICfg
{
    public static Dictionary<int, StageCfgData> data;

    public Type GetDataType()
    {
        return typeof(Dictionary<int, StageCfgData>);
    }

    public void FillData(object o)
    {
        data = (Dictionary<int, StageCfgData>)o;
    }

    public void LoadOverDeal() { }
}

public class StageCfgData
{
    [JsonProperty]
    public int id { private set; get; }
    [JsonProperty]
    public int[] max_size { private set; get; }
    [JsonProperty]
    public int room_num { private set; get; }
    [JsonProperty]
    public int[] battle_room_pool { private set; get; }
    [JsonProperty]
    public int[] treasure_room_pool { private set; get; }
    [JsonProperty]
    public int[] event_room_pool { private set; get; }
    [JsonProperty]
    public int boss_room { private set; get; }
}
