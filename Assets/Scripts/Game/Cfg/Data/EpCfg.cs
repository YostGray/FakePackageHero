using Newtonsoft.Json;
using System;
using System.Collections.Generic;


//背包初始化配置
public class EpCfg : ICfg
{
    public static Dictionary<int, EpCfgData> data;

    public Type GetDataType()
    {
        return typeof(Dictionary<int, EpCfgData>);
    }

    public void FillData(object o)
    {
        data = (Dictionary<int, EpCfgData>)o;
    }

    public void LoadOverDeal() { }
}

public class EpCfgData
{
    [JsonProperty]
    public int id { private set; get; }
    [JsonProperty]
    public string name { private set; get; }
    [JsonProperty]
    public string scene_name { private set; get; }
    [JsonProperty]
    public int[] stage_list { private set; get; }
}
