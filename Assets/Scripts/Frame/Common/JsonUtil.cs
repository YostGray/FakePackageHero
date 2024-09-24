using System;
using System.IO;
using UnityEngine;
using Newtonsoft.Json;

/// <summary>
/// Json工具类
/// </summary>
public static class JsonUtil
{
    /// <summary>
    /// 从路径读取Json，然后反序列化
    /// </summary>
    public static T DeserializeJsonFromPath<T>(string path)
    {
        if (!File.Exists(path))
        {
            return default(T);
        }
        using (StreamReader streamReader = new StreamReader(path))
        {
            string json = streamReader.ReadToEnd();
            if (string.IsNullOrEmpty(json))
            {
                return default(T);
            }
            return DeserializeJson<T>(json);
        }
    }

    /// <summary>
    /// 反序列化Json
    /// </summary>
    public static T DeserializeJson<T>(string json)
    {
        return JsonConvert.DeserializeObject<T>(json);
    }

    /// <summary>
    /// 反序列化Json
    /// </summary>
    public static object DeserializeJson(Type type,string json)
    {
        return JsonConvert.DeserializeObject(json, type);
    }

    /// <summary>
    /// 序列化Json
    /// </summary>
    public static void SerializeJson<T>(T obj, string savePath)
    {
        string dir = Path.GetDirectoryName(savePath);
        try
        {
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(savePath));
            }
            if (!File.Exists(savePath))
            {
                FileStream fs = File.Create(savePath);
                fs.Close();
            }
            string json = JsonConvert.SerializeObject(obj);
            File.WriteAllText(savePath, json);
        }
        catch (UnauthorizedAccessException e)
        {
            Debug.LogError(e);
        }

    }
}
