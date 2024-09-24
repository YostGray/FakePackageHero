using System;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 资源加载器
/// </summary>
public class ResLoader : IPoolClass
{
    private List<IRes> allRes = new List<IRes>();

    /// <summary>
    /// 加载资源
    /// </summary>
    public T Load<T>(string path) where T : UnityEngine.Object
    {
        ResBase<T> res = GetDiffRes<T>(path);
        allRes.Add(res);
        if (res == null)
            return default(T);

        T result = res.ResLoad();

        return result;
    }

    /// <summary>
    /// 异步加载资源
    /// </summary>
    public void LoadAsync<T>(string path, Action<T> finishAction) where T : UnityEngine.Object
    {
        ResBase<T> res = GetDiffRes<T>(path);
        allRes.Add(res);
        if (res == null)
        {
            finishAction(default(T));
            return;
        }
        res.ResLoadAsync(finishAction);
        return;
    }

    /// <summary>
    /// 加载AB
    /// </summary>
    public AssetBundle LoadAB(string ABName)
    {
        BundleRes<AssetBundle> bundleRes = new BundleRes<AssetBundle>(ABName);
        allRes.Add(bundleRes);
        return bundleRes.ResLoad();
    }

    /// <summary>
    /// 异步加载AB
    /// </summary>
    public void LoadABAsync(string ABName, Action<AssetBundle> finishAction)
    {
        BundleRes<AssetBundle> bundleRes = new BundleRes<AssetBundle>(ABName);
        allRes.Add(bundleRes);
        bundleRes.ResLoadAsync(finishAction);
    }

    /// <summary>
    /// 获取加载资源用的Res
    /// </summary>
    private ResBase<T> GetDiffRes<T>(string path) where T : UnityEngine.Object
    {
        if (string.IsNullOrEmpty(path))
        {
            Debug.LogError(string.Format("资源加载失败，路径为{0}，类型为{1}", path, typeof(T).Name));
            return null;
        }
        ResBase<T> res;
#if UNITY_EDITOR
        if (ResLoadManager.useABInEditor)
            res = new BundleAssetRes<T>(path);
        else
            res = new EditorRes<T>(path);
#else
        res = new BundleAssetRes<T>(path);
#endif
        return res;
    }

    public void OnGet() { }
    public void OnRecycle()
    {
        //释放资源
        if (allRes.Count > 0)
        {
            foreach (IRes res in allRes)
            {
                if (res.resState == eResState.loadDone)
                {
                    res.ReleaseAsset();
                }
                else if (res.resState == eResState.wait2Load)//协程Action加到队列里了
                {
                    res.RemoveFromeWait2LoadCoroutieQueeu();
                }
                else if (res.resState == eResState.loading)//协程开始跑了
                {
                    res.StopResLoadAsyncRoutine();
                }
            }
            allRes.Clear();
        }
    }
    public void OnRemove()
    {
        OnRecycle();
    }


    public void Recycle()
    {
        ResLoadManager.RecycleResLoader(this);
    }
}
