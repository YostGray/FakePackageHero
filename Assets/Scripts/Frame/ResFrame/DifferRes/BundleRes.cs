using System;
using System.Collections;
using UnityEngine;

/// <summary>
/// 读取AssetBundle
/// </summary>
public class BundleRes<T> : ResBase<T> where T : AssetBundle
{
    private string ABName;

    public BundleRes(string ABName) : base()
    {
        this.ABName = ABName.ToLower();//全是小写
    }

    public override T ResLoad()
    {
        AssetBundle AB = ResLoadManager.LoadAB(ABName);
        _resState = eResState.loadDone;
        return AB as T;
    }

    protected override IEnumerator m_ResLoadAsyncCoroutine()
    {
        yield return ResLoadManager.LoadABAsync(ABName, finishAction as Action<AssetBundle>);
        _resState = eResState.loadDone;
        loadOverCallback?.Invoke();
    }

    public override void ReleaseAsset()
    {
        ResLoadManager.ReleaseAB(ABName);
        base.ReleaseAsset();
    }
}