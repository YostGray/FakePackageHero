using Newtonsoft.Json;
using System;
using System.Collections.Generic;


//背包初始化配置
public class EnemyCfg : ICfg
{
    public static Dictionary<int, EnemyCfgData> data;

    public Type GetDataType()
    {
        return typeof(Dictionary<int, EnemyCfgData>);
    }

    public void FillData(object o)
    {
        data = (Dictionary<int, EnemyCfgData>)o;
    }

    public void LoadOverDeal() { }
}

public class EnemyCfgData
{
    [JsonProperty]
    public int id { private set; get; }
    [JsonProperty]
    public string name { private set; get; }
    [JsonProperty]
    public int default_HP { private set; get; }
    [JsonProperty]
    public string res { private set; get; }
    [JsonProperty]
    public string script { private set; get; }
    [JsonProperty]
    public int[] size { private set; get; }
    [JsonProperty]
    public int[] center_offset { private set; get; }
}
