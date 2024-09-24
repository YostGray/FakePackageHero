using Newtonsoft.Json;
using System;
using System.Collections.Generic;


//背包初始化配置
public class BagInitStateCfg : ICfg
{
    public static Dictionary<int, BagInitStateData> data;

    public Type GetDataType()
    {
        return typeof(Dictionary<int, BagInitStateData>);
    }

    public void FillData(object o)
    {
        data = (Dictionary<int, BagInitStateData>)o;
    }

    public void LoadOverDeal(){}
}

public class BagInitStateData 
{
    [JsonProperty]
    public int id { private set; get; }
    [JsonProperty]
    public int[] default_size { private set; get; }
    [JsonProperty]
    public int[] max_szie { private set; get; }

    public List<int> GetDefaultOpenList()
    {
        List<int> list = new List<int>();

        //0 as start
        int xStart = (max_szie[0] - default_size[0]) / 2;
        int yStart = (max_szie[1] - default_size[1]) / 2;

        for (int x = xStart; x < xStart + default_size[0]; x++)
        {
            for (int y = yStart; y < yStart + default_size[1]; y++)
            {
                int coord = BagCtrl.GetCoordinateFromPos(x,y);
                list.Add(coord);
            }
        }
        return list;
    }
}
