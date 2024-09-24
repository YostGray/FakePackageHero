using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

/// <summary>
/// AB配置数据类
/// </summary>
[System.Serializable]
public class GeneratorCfgData
{
    public string ABExtension = ".ab";
    public readonly string ABPackageCfgsJsonPath = Path.Combine(Application.dataPath, "Editor", "ABCfg", "ABCfg.json");
    public readonly string ABStorePath = Path.Combine(Directory.GetParent(Application.dataPath).FullName, "AssetsBundle");//打包结果存储位置
    public readonly string ABCopyPath = Path.Combine(Application.streamingAssetsPath, "AssetsBundle");//打包结果拷贝存储位置
    public bool isWarnAutoDepBundleSize = true;//是否警告自动依赖收集包大小
    public float warnAutoDepBundleFileSize_KB = 1024.0f;//警告自动依赖收集包大小(单位KB)

    ///获取文件时 需要忽略的文件后缀名
    public List<string> notCollectFileExtensions = new List<string>();
    ///获取文件时 需要忽略的文件夹
    public List<string> notCollectDirFullName = new List<string>();
    ///收集依赖时 需要忽略的文件后缀名
    public List<string> notCollectFileExtensions_Dependencies = new List<string>();
    ///收集依赖时 需要忽略的被依赖的文件后缀名
    public List<string> notCollectFileExtensions_Dependencies_Dep= new List<string>();

    ///打包选项
    public BuildAssetBundleOptions buildAssetBundleOptions = BuildAssetBundleOptions.ChunkBasedCompression | BuildAssetBundleOptions.ForceRebuildAssetBundle;
    ///打包目标平台
    public BuildTarget buildTarget = EditorUserBuildSettings.activeBuildTarget;
    ///是否清空输出目录
    public bool isCleanOutputDir = true;
    ///拷贝到SteamingAssets
    public bool copy2SteamingAssets = false;
}

