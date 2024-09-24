using Newtonsoft.Json;
using System;
using System.Collections.Generic;


//背包初始化配置
public class ItemCfg : ICfg
{
    public static Dictionary<int, ItemCfgData> data;

    public Type GetDataType()
    {
        return typeof(Dictionary<int, ItemCfgData>);
    }

    public void FillData(object o)
    {
        data = (Dictionary<int, ItemCfgData>)o;
    }

    public void LoadOverDeal() { }
}

public class ItemCfgData
{
    [JsonProperty]
    public int id { private set; get; }
    [JsonProperty]
    public string name { private set; get; }
    [JsonProperty]
    public string res { private set; get; }
    [JsonProperty]
    public string size { private set; get; }
    [JsonProperty]
    public string script { private set; get; }
    [JsonProperty]
    public int[] default_tag { private set; get; }
    [JsonProperty]
    public string des { private set; get; }
    [JsonProperty]
    public string func_des { private set; get; }

    [JsonIgnore]
    private List<Tag> _DefaultTags;
    [JsonIgnore]
    public List<Tag> DefaultTags { 
        get {
            if (_DefaultTags == null){
                _DefaultTags = new List<Tag>();
                for (int i = 0; i < default_tag.Length; i++)
                {
                    int tagId = default_tag[i];
                    _DefaultTags.Add(TagRegister.Id2Tag(tagId));
                }
            }
            return _DefaultTags;
        }
    }

}
