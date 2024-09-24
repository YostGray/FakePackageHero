using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

//非AOT的入口 由DLLLoader反射调用
public static class Launcher
{
    public static void InitGame()
    {
        ResLoadManager.TryReadManifest();
        MySceneManager.Instance.LoadABAsync("Main", OnMainLoadOver);
    }

    private static void OnMainLoadOver(AsyncOperation asyncOp)
    {
        var launcher = SceneManager.GetSceneByName("Launcher");
        SceneManager.UnloadSceneAsync(launcher.buildIndex);//卸载Launcher
    }
}