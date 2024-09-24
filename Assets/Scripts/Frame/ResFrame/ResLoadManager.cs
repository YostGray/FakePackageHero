using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 资源加载管理器
/// </summary>
public static class ResLoadManager
{
#if UNITY_EDITOR
    /// <summary>
    /// 在编辑器中也使用AB
    /// </summary>
    public static bool useABInEditor
    {
        set
        {
            UnityEditor.EditorPrefs.SetBool("useABInEditor", value);
        }
        get
        {
            return UnityEditor.EditorPrefs.GetBool("useABInEditor");
        }
    }
#endif
    /// <summary>
    /// ResLoader的对象池
    /// </summary>
    private static ClassObjectPool<ResLoader> resLoaderPool = new ClassObjectPool<ResLoader>(5);
    /// <summary>
    /// 自定义清单
    /// </summary>
    private static CustomManifest customManifest;
    /// <summary>
    /// 系统的清单
    /// </summary>
    private static AssetBundleManifest manifest;
    /// <summary>
    /// 已加载的AB包字典
    /// </summary>
    private static Dictionary<string, AssetBundle> loadedAssetBundleDic = new Dictionary<string, AssetBundle>();
    /// <summary>
    /// AB的引用计数字典
    /// <para>当加载AB时 此AB以及其依赖的AB引用次数+1</para>
    /// <para>当卸载此AB时 此AB以及其依赖的AB引用次数-1</para>
    /// <para>引用次数为0时真正释放此资源</para>
    /// </summary>
    private static Dictionary<AssetBundle, int> AssetBundleUsedNum = new Dictionary<AssetBundle, int>();
    /// <summary>
    /// 等待加载的协程Action
    /// </summary>
    private static List<Action<Action>> wait2LoadCoroutines = new List<Action<Action>>();
    /// <summary>
    /// 是否正在使用协程异步加载
    /// </summary>
    private static bool isAsyncLoading = false;


    public static ResLoader GetResLoader()
    {
        return resLoaderPool.Get(true);
    }

    public static void RecycleResLoader(ResLoader resLoader)
    {
        resLoaderPool.Recycle(resLoader);
    }

    /// <summary>
    /// 试着加载清单文件
    /// </summary>
    public static void TryReadManifest()
    {
#if UNITY_EDITOR
        if (!useABInEditor)
        {
            return;
        }
#endif
        //加载CustomManifest
        string mySavePath = PathHelper.GetABDir(CustomManifest.saveName);
        customManifest = JsonUtil.DeserializeJsonFromPath<CustomManifest>(mySavePath);
        if (customManifest == null) { Debug.LogError("can't load customManifest"); }

        string savePath = PathHelper.GetABDir(PathHelper.manifestName);
        manifest = AssetBundle.LoadFromFile(savePath).LoadAsset<AssetBundleManifest>("AssetBundleManifest");
    }

    /// <summary>
    /// 所有的AB内是不是有某个资源
    /// </summary>
    public static bool IsAllABHaveRes(string resPath, out string ABName)
    {
        customManifest.res2ABDic.TryGetValue(resPath, out ABName);
        return !string.IsNullOrEmpty(ABName);
    }

    /// <summary>
    /// 获取AB是否已经加载过了
    /// </summary>
    public static bool GetIsLoadedAB(string ABName, out AssetBundle AB)
    {
        if (loadedAssetBundleDic.ContainsKey(ABName))
        {
            AB = loadedAssetBundleDic[ABName];
            return true;
        }
        AB = null;
        return false;
    }

    /// <summary>
    /// 加载AB
    /// </summary>
    public static AssetBundle LoadAB(string ABName)
    {
        AssetBundle AB;
        if (GetIsLoadedAB(ABName, out AB))
        {
            AssetBundleUsedNum[AB]++;
        }
        else
        {
            string abPath = PathHelper.GetABDir(ABName);
            AB = AssetBundle.LoadFromFile(abPath);
            loadedAssetBundleDic.Add(ABName, AB);
            AssetBundleUsedNum.Add(AB, 1);
        }

        foreach (string dpABName in manifest.GetAllDependencies(ABName))
        {
            AssetBundle dpAB;
            if (GetIsLoadedAB(dpABName, out dpAB))
            {
                AssetBundleUsedNum[dpAB]++;
            }
            else
            {
                string dpABPath = PathHelper.GetABDir(dpABName);
                dpAB = AssetBundle.LoadFromFile(dpABPath);
                loadedAssetBundleDic.Add(dpABName, dpAB);
                AssetBundleUsedNum.Add(dpAB, 1);
            }

        }
        return AB;
    }

    /// <summary>
    /// 异步加载AB
    /// </summary>
    public static IEnumerator LoadABAsync(string ABName, Action<AssetBundle> finishAction)
    {
        AssetBundle AB;
        if (GetIsLoadedAB(ABName, out AB))
        {
            AssetBundleUsedNum[AB]++;
            finishAction?.Invoke(AB);
        }
        else
        {
            string abPath = PathHelper.GetABDir(ABName);
            AssetBundleCreateRequest assetBundleCreateRequest = AssetBundle.LoadFromFileAsync(abPath);
            yield return assetBundleCreateRequest;
            AB = assetBundleCreateRequest.assetBundle;
            loadedAssetBundleDic.Add(ABName, AB);
            AssetBundleUsedNum.Add(AB, 1);
        }

        foreach (string dpABName in manifest.GetAllDependencies(ABName))
        {
            AssetBundle dpAB;
            if (GetIsLoadedAB(dpABName, out dpAB))
            {
                AssetBundleUsedNum[dpAB]++;
            }
            else
            {
                string dpABPath = PathHelper.GetABDir(dpABName);
                AssetBundleCreateRequest assetBundleCreateRequest2 = AssetBundle.LoadFromFileAsync(dpABPath);
                yield return assetBundleCreateRequest2;
                dpAB = assetBundleCreateRequest2.assetBundle;
                loadedAssetBundleDic.Add(dpABName, dpAB);
                AssetBundleUsedNum.Add(dpAB, 1);
            }
        }
        finishAction?.Invoke(AB);
    }

    /// <summary>
    /// 添加等待加载中的协程
    /// </summary>
    public static void AddWait2LoadCoroutine(Action<Action> action)
    {
        wait2LoadCoroutines.Add(action);
        if (!isAsyncLoading)
        {
            TryRunNext2LoadCoroutine();
        }
    }

    /// <summary>
    /// 跑下一个异步加载协程
    /// </summary>
    private static void TryRunNext2LoadCoroutine()
    {
        if (wait2LoadCoroutines.Count <= 0)
        {
            isAsyncLoading = false;
            return;
        }

        Action<Action> loadAction = wait2LoadCoroutines[0];
        wait2LoadCoroutines.RemoveAt(0);
        isAsyncLoading = true;
        loadAction.Invoke(TryRunNext2LoadCoroutine);
    }

    /// <summary>
    /// 移除等待加载中的协程
    /// </summary>
    public static void RemoveWait2LoadCoroutine(Action<Action> action)
    {
        if (wait2LoadCoroutines.Contains(action))
        {
            wait2LoadCoroutines.Remove(action);
        }
    }

    //释放一个AB
    public static void ReleaseAB(string ABName)
    {
        bool isHaveAB = loadedAssetBundleDic.TryGetValue(ABName, out AssetBundle AB);
        if (!isHaveAB)
        {
            return;
        }

        int refNum = --AssetBundleUsedNum[AB];
        if (refNum <= 0)
        {
            AssetBundleUsedNum.Remove(AB);
            loadedAssetBundleDic.Remove(ABName);
            AB.Unload(true);
        }

        string[] depABNames = manifest.GetAllDependencies(ABName);
        foreach (string dpABName in depABNames)
        {
            AssetBundle dpAB;
            if (GetIsLoadedAB(dpABName, out dpAB))
            {
                refNum = --AssetBundleUsedNum[dpAB];
                if (refNum <= 0)
                {
                    AssetBundleUsedNum.Remove(dpAB);
                    loadedAssetBundleDic.Remove(dpABName);
                    dpAB.Unload(true);
                }
            }
        }
    }
}