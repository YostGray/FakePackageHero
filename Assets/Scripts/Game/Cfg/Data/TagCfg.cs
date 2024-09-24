using Newtonsoft.Json;
using System;
using System.Collections.Generic;


//背包初始化配置
public class TagCfg : ICfg
{
    public static Dictionary<int, TagCfgData> data;

    public Type GetDataType()
    {
        return typeof(Dictionary<int, TagCfgData>);
    }

    public void FillData(object o)
    {
        data = (Dictionary<int, TagCfgData>)o;
    }

    public void LoadOverDeal() { }
}

public class TagCfgData
{
    [JsonProperty]
    public int id { private set; get; }
    [JsonProperty]
    public string name { private set; get; }
    [JsonProperty]
    public string code_name { private set; get; }
}
