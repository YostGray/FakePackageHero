#if UNITY_EDITOR
using System.Collections;
using UnityEditor;
using UnityEngine;

/// <summary>
/// 从原始目录中读取文件(开发用)
/// </summary>
public class EditorRes<T> : ResBase<T> where T : UnityEngine.Object
{
    private string path;
    public EditorRes(string path) : base()
    {
        this.path = path.ToLower();//全是小写
    }
    public override T ResLoad()
    {
        T res = AssetDatabase.LoadAssetAtPath<T>(path);
        if (res == null)
        {
            Debug.LogError(string.Format("资源加载失败，路径为{0}，类型为{1}", path, typeof(T).Name));
            return default(T);
        }
        _resState = eResState.loadDone;
        return res;
    }

    protected override IEnumerator m_ResLoadAsyncCoroutine()
    {
        if (EditorResGM.isManualDelayResLoad)
            yield return new WaitForSeconds(0.5f);

        T res = AssetDatabase.LoadAssetAtPath<T>(path);
        if (res == null)
        {
            Debug.LogError(string.Format("资源加载失败，路径为{0}，类型为{1}", path, typeof(T).Name));
            finishAction?.Invoke(default(T));
        }
        else
        {
            finishAction?.Invoke(res);
        }
        _resState = eResState.loadDone;

        loadOverCallback?.Invoke();
    }

    public override void ReleaseAsset()
    {
        base.ReleaseAsset();
    }
}

public static class EditorResGM
{
    /// <summary>
    /// 是否手动延迟资源加载
    /// </summary>
    public static bool isManualDelayResLoad = false;
    const string switchDelayResLoadMenuStr = "GM/延迟资源加载(Debug用)";

    [MenuItem(switchDelayResLoadMenuStr)]
    public static void SwitchDelayResLoad()
    {
        isManualDelayResLoad = !isManualDelayResLoad;
        Debug.Log($"切换延迟资源加载状态:{isManualDelayResLoad}");
    }

    [MenuItem(switchDelayResLoadMenuStr, true)]
    private static bool ValidateSwitchDelayResLoad()
    {
        Menu.SetChecked(switchDelayResLoadMenuStr, isManualDelayResLoad);
        return true;
    }
}
#endif
