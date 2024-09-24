using Newtonsoft.Json;
using System;
using System.Collections.Generic;


//背包初始化配置
public class HeroCfg : ICfg
{
    public static Dictionary<int, HeroCfgData> data;

    public Type GetDataType()
    {
        return typeof(Dictionary<int, HeroCfgData>);
    }

    public void FillData(object o)
    {
        data = (Dictionary<int, HeroCfgData>)o;
    }

    public void LoadOverDeal() { }
}

public class HeroCfgData
{
    [JsonProperty]
    public int id { private set; get; }
    [JsonProperty]
    public string name { private set; get; }
    [JsonProperty]
    public int default_HP { private set; get; }
    [JsonProperty]
    public int default_AP { private set; get; }
    [JsonProperty]
    public int default_MP { private set; get; }
}
