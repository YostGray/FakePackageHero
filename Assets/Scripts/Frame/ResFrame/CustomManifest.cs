using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

/// <summary>
/// 自定义资源查找清单
/// </summary>
public class CustomManifest
{
    public readonly static string saveName = "custom_manifest.json";
    /// <summary>
    /// 具体资源到AB的字典
    /// </summary>
    public Dictionary<string, string> res2ABDic = new Dictionary<string, string>();
    ///// <summary>
    ///// AB名字到ABData字典
    ///// </summary>
    //public Dictionary<string, string> ABName2ABDataDic = new Dictionary<string, string>();

    public void AddRes(string resPath,string ABPath)
    {
        if (res2ABDic.ContainsKey(resPath))
        {
            Debug.LogWarning(string.Format("{0}有重复的AB {1} 和 {2}", resPath, res2ABDic[resPath], ABPath));
            return;
        }

        res2ABDic.Add(resPath, ABPath);
    }

    //public void AddABData(string ABPath, ABData data)
    //{
    //    if (ABName2ABDataDic.ContainsKey(ABPath))
    //    {
    //        return;
    //    }
    //    ABName2ABDataDic.Add(ABPath, data);
    //}
}

//public struct ABData
//{
//    string[] depends;
//}
