using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;
using System.Linq;
using System;

/**
AB打包的规则说明:
    使用配置规则打包，收集要打包的文件的依赖。
    被依赖但是没有配置的文件，和其它所有的孤立文件一起打包，大于警告文件数量就弹出警告看看怎么优化配置。

    文件夹方式不可递归，需要配合目录管理使用
**/

/// <summary>
/// AB打包主文件
/// </summary>
public static class AssetBundleGenerator
{
    private static string GeneratorCfgJsonPath { get; } = Path.Combine(Application.dataPath, "Editor", "ABCfg", "ABGeneroatorCfg.json");
    public static GeneratorCfgData generatorCfg { private set; get; }
    public static List<ABPackageCfgData> ABCfgList { private set; get; }

    /// <summary>
    /// 读取或者初始化打包配置
    /// </summary>
    public static void ReadOrCreatCfgDatas()
    {
        if (generatorCfg == null)
        {
            generatorCfg = JsonUtil.DeserializeJsonFromPath<GeneratorCfgData>(GeneratorCfgJsonPath);
        }
        if (generatorCfg == null)
        {
            generatorCfg = new GeneratorCfgData();
        }
        ABCfgList = JsonUtil.DeserializeJsonFromPath<List<ABPackageCfgData>>(generatorCfg.ABPackageCfgsJsonPath);
        if (ABCfgList == null)
        {
            ABCfgList = new List<ABPackageCfgData>();
        }
    }

    public static void SaveGeneratorCfg()
    {
        JsonUtil.SerializeJson<GeneratorCfgData>(generatorCfg, GeneratorCfgJsonPath);
    }

    public static void SaveABCfgs()
    {
        JsonUtil.SerializeJson<List<ABPackageCfgData>>(ABCfgList, generatorCfg.ABPackageCfgsJsonPath);
    }

    /// <summary>
    /// 开始AB打包
    /// </summary>
    public static void StartGenABs()
    {
        ////防止没有保存
        //SaveGeneratorCfg();
        //SaveABCfgs();

        try
        {
            //生成中间数据
            List<ABMidData> midDatas = GenABMidData();
            //处理收集依赖
            CollectDependencies(midDatas);

            //生成最终的unity用的打包配置
            List<AssetBundleBuild> ABBList = GenRealABBuilData(midDatas);
            //打包AB包
            BuildAB(ABBList);
        }
        catch (CancleBuildABException e)
        {
            Debug.LogWarning(e);
            throw;
        }

        EditorUtility.ClearProgressBar();//关掉进度条
    }

    /// <summary>
    /// 创建一个打包中间数据
    /// </summary>
    private static List<ABMidData> GenABMidData()
    {
        List<ABMidData> ABMidDataList = new List<ABMidData>();
        foreach (ABPackageCfgData ABCfgData in ABCfgList)
        {
            #region 进度条
            float rate = ABCfgList.IndexOf(ABCfgData) / ABCfgList.Count;
            if (EditorUtility.DisplayCancelableProgressBar("打包中", "正在生成打包中间数据", rate))
            {
                throw new CancleBuildABException("取消生成打包中间数据");
            }
            #endregion

            if (!ABCfgData.isUsing)
                continue;

            switch (ABCfgData.packWay)
            {
                case ePackWay.none:
                    Debug.LogWarning(string.Format("打包规则\"{0}\"的打包方式未确定，请检查配置", ABCfgData.name));
                    break;
                case ePackWay.eachFile:
                    { 
                        Dictionary<string, List<string>> filePathDic = GetFilePaths(ABCfgData);
                        foreach (var filePathPair in filePathDic)
                        {
                            foreach (string filePath in filePathPair.Value)
                            {
                                ABMidData midData = new ABMidData();//每个文件一个
                                midData.ABName = filePath + generatorCfg.ABExtension;
                                //midData.ABName = midData.ABName.ToLower();

                                midData.assetNameSet.Add(filePath);
                                midData.isForceIncludeDepends = ABCfgData.isForceIncludeDepends;
                                ABMidDataList.Add(midData);
                            }
                        }
                    }
                    break;
                case ePackWay.eachFolder:
                    {
                        Dictionary<string, List<string>> filePathDic = GetFilePaths(ABCfgData);
                        foreach (var filePathPair in filePathDic)
                        {
                            ABMidData midData = new ABMidData();//每个文件夹一个
                            midData.ABName = filePathPair.Key + generatorCfg.ABExtension;
                            //midData.ABName = midData.ABName.ToLower();

                            foreach (string filePath in filePathPair.Value)
                            {
                                midData.assetNameSet.Add(filePath);
                            }
                            midData.isForceIncludeDepends = ABCfgData.isForceIncludeDepends;
                            ABMidDataList.Add(midData);
                        }
                    }
                    break;
                case ePackWay.total:
                    { 
                        Dictionary<string, List<string>> filePathDic = GetFilePaths(ABCfgData);
                        ABMidData midData = new ABMidData();//所有文件一个
                        if (filePathDic.Count > 1)
                            Debug.LogError("total模式出现不止一个目录!");
                        foreach (var filePathPair in filePathDic)
                        {
                            midData.ABName = filePathPair.Key + generatorCfg.ABExtension;
                            //midData.ABName = midData.ABName.ToLower();
                            foreach (string filePath in filePathPair.Value)
                            {
                                midData.assetNameSet.Add(filePath);
                            }
                            break;
                        }
                        midData.isForceIncludeDepends = ABCfgData.isForceIncludeDepends;
                        ABMidDataList.Add(midData);
                    }
                    break;
                default:
                    break;
            }
        }
        return ABMidDataList;
    }

    /// <summary>
    /// 收集依赖
    /// </summary>
    /// <returns>被重复依赖的资源的集合</returns>
    private static void CollectDependencies(List<ABMidData> midDatas)
    {
        //生成每个资源属于那个AB
        Dictionary<string, string> asset2ABDic = new Dictionary<string, string>();
        foreach (ABMidData ABMidData in midDatas)
        {
            #region 进度条
            float rate = midDatas.IndexOf(ABMidData) / midDatas.Count;
            if (EditorUtility.DisplayCancelableProgressBar("打包中", "正在生成每个资源属于那个AB", rate))
            {
                throw new CancleBuildABException("取消生成每个资源属于那个AB");
            }
            #endregion
            foreach (string assetPath in ABMidData.assetNameSet)
            {
                if (!asset2ABDic.ContainsKey(assetPath))
                    asset2ABDic.Add(assetPath, ABMidData.ABName);
                else
                    Debug.LogWarning(string.Format("{0} 与 {1} 有同一个资源:{2}",asset2ABDic[assetPath], ABMidData.ABName, assetPath));

                //强制包含的依赖优先放进来
                if (ABMidData.isForceIncludeDepends)
                {
                    List<string> dependencies = GetAssetDependencies(assetPath);
                    foreach (string dependAssetPath in dependencies)
                    {
                        ABMidData.forceAssetNameSet.Add(dependAssetPath);
                        asset2ABDic.Add(dependAssetPath, ABMidData.ABName);
                    }
                }
            }
        }

        //处理共享的部分
        Dictionary<string,int> sharedAssetDic = new Dictionary<string, int>();//被共享的依赖的
        foreach (ABMidData ABMidData in midDatas)
        {
            #region 进度条
            float rate = midDatas.IndexOf(ABMidData) / midDatas.Count;
            if (EditorUtility.DisplayCancelableProgressBar("打包中", "正在收集依赖", rate))
            {
                throw new CancleBuildABException("取消收集依赖");
            }
            #endregion
            if (!ABMidData.isForceIncludeDepends)
            {
                HashSet<string> tempHashSet = new HashSet<string>(ABMidData.assetNameSet);
                foreach (string assetPath in tempHashSet)
                {
                    List<string> dependencies = GetAssetDependencies(assetPath);
                    foreach (string dependAssetPath in dependencies)
                    {
                        if (asset2ABDic.ContainsKey(dependAssetPath))//在其它AB里了，标记一下就好
                        {
                            ABMidData.dependencies.Add(asset2ABDic[dependAssetPath]);
                        }
                        else
                        {
                            ABMidData.assetNameSet.Add(dependAssetPath);
                            if (sharedAssetDic.ContainsKey(dependAssetPath))
                            {
                                sharedAssetDic[dependAssetPath] += 1;
                            }
                            else
                            {
                                sharedAssetDic.Add(dependAssetPath, 1);
                            }
                        }
                    }
                }
            }
        }
        HashSet<string> sharedAssetSet = new HashSet<string>();
        foreach (var sharedAssetNumPair in sharedAssetDic)
        {
            if (sharedAssetNumPair.Value > 1)
            {
                sharedAssetSet.Add(sharedAssetNumPair.Key);
            }
        }

        if (sharedAssetSet.Count > 0)
        {
            /// 移除被打成共享AB的依赖
            foreach (ABMidData ABMidData in midDatas)
            {
                ABMidData.assetNameSet.ExceptWith(sharedAssetSet);
            }
            /// 自动依赖包
            ABMidData midData = new ABMidData();
            midData.ABName = "Assets/_Res/sharedAB" + generatorCfg.ABExtension;
            midData.assetNameSet = sharedAssetSet;
            midDatas.Add(midData);
        }

        return;
    }

    /// <summary>
    /// 生成供打包用的AssetBundleBuild的List
    /// </summary>
    private static List<AssetBundleBuild> GenRealABBuilData(List<ABMidData> midDatas)
    {
        List<AssetBundleBuild> ABBList = new List<AssetBundleBuild>();
        foreach (var ABMidData in midDatas)
        {
            AssetBundleBuild abb = new AssetBundleBuild();
            if (ABMidData.ABName.StartsWith("Assets/",StringComparison.OrdinalIgnoreCase))
            {
                ABMidData.ABName = ABMidData.ABName.Substring("Assets/".Length);
            }
            abb.assetBundleName = ABMidData.ABName;
            HashSet<string> unionSet = new HashSet<string>();
            unionSet.UnionWith(ABMidData.assetNameSet);
            unionSet.UnionWith(ABMidData.forceAssetNameSet);
            abb.assetNames = unionSet.ToArray();
            ABBList.Add(abb);
        }
        return ABBList;
    }

    /// <summary>
    /// 开始打包
    /// </summary>
    private static void BuildAB(List<AssetBundleBuild> ABBList)
    {
        BuildTarget buildTarget;
        buildTarget = generatorCfg.buildTarget;

        string outputPath = Path.Combine(generatorCfg.ABStorePath, BuildPipeline.GetBuildTargetName(buildTarget));
        AssetBundleBuild[] builds = ABBList.ToArray();
        BuildAssetBundleOptions options;
        if (generatorCfg.buildAssetBundleOptions != BuildAssetBundleOptions.None)
            options = generatorCfg.buildAssetBundleOptions;
        else
            options = BuildAssetBundleOptions.ChunkBasedCompression | BuildAssetBundleOptions.DeterministicAssetBundle | BuildAssetBundleOptions.ForceRebuildAssetBundle;

        if (string.IsNullOrEmpty(outputPath))
            throw new CancleBuildABException("outputPath is empty");

        if (builds.Length == 0)
            throw new CancleBuildABException("builds is empty");

        if (Directory.Exists(outputPath))//清空目录
            Directory.Delete(outputPath, true);
        Directory.CreateDirectory(outputPath);

        AssetBundleManifest manifest = BuildPipeline.BuildAssetBundles(outputPath, builds, options, buildTarget);
        if (manifest != null)//打包成功
        {
            WriteCustomAssetsManifest(manifest, outputPath);
            if (generatorCfg.copy2SteamingAssets)
            {
                Copy2SteamingAssets();
            }
        }
    }

    /// <summary>
    /// 根据配置获取文件全目录
    /// </summary>
    /// <returns>
    /// key:目录路径 value:文件路径列表
    /// </returns>
    private static Dictionary<string, List<string>> GetFilePaths(ABPackageCfgData ABCfgData)
    {
        string assetDir = ABCfgData.assetDir.Replace('\\', '/');
        string searchePattern = ABCfgData.searchePattern;
        bool isRecursionSearch = ABCfgData.isRecursionSearch;
        bool isIncludeTopDir = ABCfgData.isIncludeTopDir;

        Dictionary<string, List<string>> filePathDic = new Dictionary<string, List<string>>();
        if (!Directory.Exists(assetDir))
            return null;

        switch (ABCfgData.packWay)
        {
            case ePackWay.eachFile://每个文件
                {
                    string[] tempFiles;
                    if (isRecursionSearch)
                        tempFiles = Directory.GetFiles(assetDir, searchePattern, SearchOption.AllDirectories);
                    else
                        tempFiles = Directory.GetFiles(assetDir, searchePattern, SearchOption.TopDirectoryOnly);

                    List<string> fileList = new List<string>();
                    foreach (string winFilePath in tempFiles)
                    {
                        if (generatorCfg.notCollectFileExtensions.Contains(Path.GetExtension(winFilePath).ToLower()))
                        {
                            continue;
                        }
                        string filePath = winFilePath.Replace('\\', '/');
                        fileList.Add(filePath);
                    }
                    filePathDic.Add(assetDir, fileList);
                }
                break;
            case ePackWay.eachFolder://每个文件夹
                {
                    List<string> folders = new List<string>();
                    if (isRecursionSearch)
                        folders.AddRange(Directory.GetDirectories(assetDir,"*.*", SearchOption.AllDirectories));
                    else
                        folders.AddRange(Directory.GetDirectories(assetDir, "*.*", SearchOption.TopDirectoryOnly));

                    if (isIncludeTopDir)
                        folders.Add(assetDir);

                    foreach (string winDirPath in folders)
                    {
                        string[] tempFiles = Directory.GetFiles(winDirPath, searchePattern, SearchOption.TopDirectoryOnly);
                        List<string> fileList = new List<string>();
                        foreach (string winFilePath in tempFiles)
                        {
                            if (generatorCfg.notCollectFileExtensions.Contains(Path.GetExtension(winFilePath).ToLower()))
                            {
                                continue;
                            }
                            string filePath = winFilePath.Replace('\\', '/');
                            fileList.Add(filePath);
                        }

                        string dirPath = winDirPath.Replace('\\', '/');
                        filePathDic.Add(dirPath, fileList);
                    }
                }
                break;
            case ePackWay.total://整个文件夹
                {
                    List<string> fileList = new List<string>();
                    filePathDic.Add(assetDir, fileList);

                    string[] tempFiles = Directory.GetFiles(assetDir, searchePattern, SearchOption.AllDirectories);
                    foreach (string winFilePath in tempFiles)
                    {
                        if (generatorCfg.notCollectFileExtensions.Contains(Path.GetExtension(winFilePath).ToLower()))
                        {
                            continue;
                        }
                        string filePath = winFilePath.Replace('\\', '/');
                        fileList.Add(filePath);
                    }
                }
                break;
            default:
                return null;
        }
        return filePathDic;
    }

    /// <summary>
    /// 获取资源的依赖
    /// </summary>
    /// <param name="filePath">资源路径</param>
    /// <param name="alreadyHaveSet">已打包的资源集合</param>
    /// <returns></returns>
    private static List<string> GetAssetDependencies(string filePath)
    {
        List<string> result = new List<string>();
        if (filePath.EndsWith(".unity"))
        {
            return result;
        }
        string[] dependencies = AssetDatabase.GetDependencies(filePath);
        foreach (string depWinPath in dependencies)
        {
            if (generatorCfg.notCollectFileExtensions_Dependencies.Contains(Path.GetExtension(depWinPath).ToLower()))
            {
                continue;
            }
            string depPath = depWinPath.Replace('\\', '/');
            if (depPath.Equals(filePath))
            {
                continue;
            }
            if (generatorCfg.notCollectFileExtensions_Dependencies_Dep.Contains(Path.GetExtension(depPath).ToLower()))
            {
                continue;
            }
            result.Add(depPath);
        }
        return result;
    }

    /// <summary>
    /// 写下自定义资源清单
    /// </summary>
    private static void WriteCustomAssetsManifest(AssetBundleManifest mainManifest, string outputPath)
    {
        string[] allABName = mainManifest.GetAllAssetBundles();
        CustomManifest customManifest = new CustomManifest();
        foreach (string ABName in allABName)
        {
            string fullPath = Path.Combine(outputPath, ABName);
            AssetBundle AB = AssetBundle.LoadFromFile(fullPath);
            if (AB == null)
            {
                Debug.LogError("无法读取AB:" + ABName);
                return;
            }
            //所有资产
            foreach (string assetName in AB.GetAllAssetNames())
            {
                customManifest.AddRes(assetName, ABName);
            }
            //所有引用
            //AssetBundleManifest manifest = AB.LoadAsset<AssetBundleManifest>("AssetBundleManifest");

            AB.Unload(true);
        }
        string savePath = Path.Combine(outputPath, CustomManifest.saveName);
        JsonUtil.SerializeJson<CustomManifest>(customManifest, savePath);
    }

    /// <summary>
    /// 拷贝到StreamingAssets中
    /// </summary>
    public static void Copy2SteamingAssets()
    {
        BuildTarget buildTarget;
        buildTarget = generatorCfg.buildTarget;
        string outputPath = Path.Combine(generatorCfg.ABStorePath, BuildPipeline.GetBuildTargetName(buildTarget));

        FileUtil.DeleteFileOrDirectory(generatorCfg.ABCopyPath);
        FileUtil.CopyFileOrDirectory(outputPath, generatorCfg.ABCopyPath);

        //重命名主清单文件
        string moveSrcPath = Path.Combine(generatorCfg.ABCopyPath, BuildPipeline.GetBuildTargetName(buildTarget));
        string moveDesPath = Path.Combine(generatorCfg.ABCopyPath, PathHelper.manifestName);
        FileUtil.MoveFileOrDirectory(moveSrcPath, moveDesPath);
    }
}

public class CancleBuildABException : Exception
{
    public CancleBuildABException(string message) : base(message)
    {

    }
}
