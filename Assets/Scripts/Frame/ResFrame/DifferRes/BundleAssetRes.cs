using System.Collections;
using UnityEngine;

/// <summary>
/// 从AssetsBundle中读取文件
/// </summary>
public class BundleAssetRes<T> : ResBase<T> where T : UnityEngine.Object
{
    private string path;
    private string ABName;
    AssetBundle AB;

    public BundleAssetRes(string path) : base()
    {
        this.path = path.ToLower();//全是小写
    }

    public override T ResLoad()
    {
        if (!ResLoadManager.IsAllABHaveRes(path, out ABName))
        {
            Debug.LogError(string.Format("资源加载失败，路径为{0}，类型为{1}", path, typeof(T).Name));
            //AB中没有这个资源
            return default(T);
        }
        AB = ResLoadManager.LoadAB(ABName);
        _resState = eResState.loadDone;
        return AB.LoadAsset<T>(path);
    }

    protected override IEnumerator m_ResLoadAsyncCoroutine()
    {
        if (!ResLoadManager.IsAllABHaveRes(path, out ABName))
        {
            Debug.LogError(string.Format("资源加载失败，路径为{0}，类型为{1}", path, typeof(T).Name));
            //AB中没有这个资源
            finishAction?.Invoke(default);
            yield break;
        }
        yield return ResLoadManager.LoadABAsync(ABName, m_GetAB);
        AssetBundleRequest assetBundleRequest = AB.LoadAssetAsync<T>(path);
        yield return assetBundleRequest;
        finishAction?.Invoke(assetBundleRequest.asset as T);
        _resState = eResState.loadDone;
        loadOverCallback?.Invoke();
        AB = null;
    }

    private void m_GetAB(AssetBundle ab)
    {
        AB = ab;
    }

    public override void ReleaseAsset()
    {
        AB = null;
        ResLoadManager.ReleaseAB(ABName);
        base.ReleaseAsset();
    }
}