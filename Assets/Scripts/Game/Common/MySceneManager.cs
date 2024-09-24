using System;
using System.Collections.Generic;
#if UNITY_EDITOR
using UnityEditor.SceneManagement;
#endif
using UnityEngine;
using UnityEngine.SceneManagement;

public class MySceneManager : Singleton<MySceneManager>
{
    Dictionary<string, ResLoader> sceneResLoaderDic = new Dictionary<string, ResLoader>();


    public void LoadABAsync(string sceneName,Action<AsyncOperation> loadOverCallback)
    {
#if UNITY_EDITOR
        if (!ResLoadManager.useABInEditor)
        {
            EditorSceneManager.LoadSceneAsyncInPlayMode("Assets/" + PathHelper.GetScenesPath(sceneName), new LoadSceneParameters(LoadSceneMode.Additive)).completed += loadOverCallback;
            return;
        }
#endif
        if (!sceneResLoaderDic.ContainsKey(sceneName))
        {
            ResLoader resLoader = ResLoadManager.GetResLoader();
            sceneResLoaderDic.Add(sceneName, resLoader);
            string ABName = PathHelper.GetScenesPath(sceneName) + PathHelper.ABExtension;
            resLoader.LoadABAsync(ABName, (AssetBundle sceneAB) =>
            {
                if (sceneAB == null)
                {
                    Debug.LogError("无法加载场景");
                    return;
                }
                string[] scenePaths = sceneAB.GetAllScenePaths();
                if (scenePaths.Length != 1)
                {
                    Debug.Log("无法明确的知道需要加载哪个场景");
                    return;
                }
                SceneManager.LoadSceneAsync(scenePaths[0],LoadSceneMode.Additive).completed += (asyncOp) => {
                    loadOverCallback?.Invoke(asyncOp);
                };
            });
        }
        else
        {
            Debug.LogError($"试图重复加载场景:{sceneName}");
        }
    }

    public void UnloadABAsync(string sceneName, Action<AsyncOperation> unloadOverCallback)
    {
        if (sceneResLoaderDic.TryGetValue(sceneName, out ResLoader resLoader))
        {
            SceneManager.UnloadSceneAsync(sceneName).completed += (asyncOp) => {
                unloadOverCallback?.Invoke(asyncOp);
                ResLoadManager.RecycleResLoader(resLoader);
            };
            sceneResLoaderDic.Remove(sceneName);//同步的移除了
        }
        else
        {
            Debug.LogError($"试图卸载不存在的场景:{sceneName}");
        }
    }
}
