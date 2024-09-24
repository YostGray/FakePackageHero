using Newtonsoft.Json;
using System;
using System.Collections.Generic;


//背包初始化配置
public class LootCfg : ICfg
{
    public static Dictionary<int, LootData> data;

    public Type GetDataType()
    {
        return typeof(Dictionary<int, LootData>);
    }

    public void FillData(object o)
    {
        data = (Dictionary<int, LootData>)o;
    }

    public void LoadOverDeal() { }
}

public class LootData
{
    [JsonProperty]
    public int id { private set; get; }
    [JsonProperty]
    public int[] loot { private set; get; }
    [JsonProperty]
    public int[] loot_chance { private set; get; }
    [JsonProperty]
    public int lucky { private set; get; }
    [JsonProperty]
    public int lucky_group { private set; get; }
}
