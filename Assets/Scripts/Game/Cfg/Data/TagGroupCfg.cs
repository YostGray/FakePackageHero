using Newtonsoft.Json;
using System;
using System.Collections.Generic;


//背包初始化配置
public class TagGroupCfg : ICfg
{
    public static Dictionary<int, TagGroupCfgData> data;

    public Type GetDataType()
    {
        return typeof(Dictionary<int, TagGroupCfgData>);
    }

    public void FillData(object o)
    {
        data = (Dictionary<int, TagGroupCfgData>)o;
    }

    public void LoadOverDeal() { }
}

public class TagGroupCfgData
{
    [JsonProperty]
    public int id { private set; get; }
    [JsonProperty]
    public string name { private set; get; }
    [JsonProperty]
    public string code_name { private set; get; }
    [JsonProperty]
    public int[] tag_list { private set; get; }
    [JsonProperty]
    public int[] inherit_group { private set; get; }
}
