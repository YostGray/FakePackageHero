using System.IO;
using UnityEngine;

public static class PathHelper
{
    public const string ABExtension = ".ab";
    public const string sceneExtension = ".unity";
    public const string prefabExtension = ".prefab";
    public const string textureExtension = ".png";
    public const string atlasExtension = ".spriteatlas";
    public const string jsonExtension = ".json";

    public const string AssetsBundleDir = "AssetsBundle/";
    public const string scenesDir = "_Res/Scenes/";
    public const string UIPrefabDir = "Assets/_Res/Prefab/UI/";
    public const string characterDir = "Assets/_Res/Prefab/Character/";
    public const string monsterDir = "Assets/_Res/Prefab/Character/Monster/";
    public const string rawImageDir = "Assets/_Res/RawImg/";
    public const string spriteAtlasDir = "Assets/_Res/Atlas/";
    public const string cfgJsonDir = "Assets/_Res/Cfg/";

    public const string manifestName = "MyManifest";

    /// <summary>
    /// 将路径加上"Assets/"作为开头
    /// </summary>
    public static string GetPathWithAssetsHead(string resPath)
    {
        return string.Concat("Assets/", resPath);
    }

    /// <summary>
    /// 读取AB的位置
    /// </summary>
    public static string GetABDir(string filePath)
    {
        return Path.Combine(BasicPathHelper.Instance.PersistentDataPath, AssetsBundleDir, filePath);
    }

    /// <summary>
    /// 获取场景的路径
    /// </summary>
    public static string GetScenesPath(string sceneName, bool withExtension = true)
    {
        if (withExtension)
        {
            return Path.Combine(scenesDir, sceneName + sceneExtension);
        }
        return Path.Combine(scenesDir, sceneName);
    }

    /// <summary>
    /// 获取UI预制体的加载路径
    /// </summary>
    public static string GetUIPrefabPath(string UIPrefabName, bool withExtension = true)
    {
        if (withExtension)
        {
            return Path.Combine(UIPrefabDir, UIPrefabName + prefabExtension);
        }
        return Path.Combine(UIPrefabDir, UIPrefabName);
    }

    /// <summary>
    /// 获取RawImage加载路径
    /// </summary>
    public static string GetRawImagePath(string imageName, bool withExtension = true)
    {
        if (withExtension)
        {
            return Path.Combine(rawImageDir, imageName + textureExtension);
        }
        return Path.Combine(rawImageDir, imageName);
    }

    /// <summary>
    /// 获取RawImage加载路径
    /// </summary>
    public static string GetAtlasePath(string atlasName, bool withExtension = true)
    {
        if (withExtension)
        {
            return Path.Combine(spriteAtlasDir, atlasName + atlasExtension);
        }
        return Path.Combine(spriteAtlasDir, atlasName);
    }

    /// <summary>
    /// 获取JsonCfg加载路径
    /// </summary>
    public static string GetJsonCfgPath(string cfgName, bool withExtension = true)
    {
        if (withExtension)
        {
            return Path.Combine(cfgJsonDir, cfgName + jsonExtension);
        }
        return Path.Combine(cfgJsonDir, cfgName);
    }

    /// <summary>
    /// 获取角色预制体的加载路径
    /// </summary>
    public static string GetCharacterPrefabPath(string name, bool withExtension = true)
    {
        if (withExtension)
        {
            return Path.Combine(characterDir, name + prefabExtension);
        }
        return Path.Combine(characterDir, name);
    }

    /// <summary>
    /// 获取敌人预制体的加载路径
    /// </summary>
    public static string GetMonsterPrefabPath(string name, bool withExtension = true)
    {
        if (withExtension)
        {
            return Path.Combine(monsterDir, name, name + prefabExtension);
        }
        return Path.Combine(monsterDir, name, name);
    }
}
