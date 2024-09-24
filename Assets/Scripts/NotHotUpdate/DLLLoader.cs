using HybridCLR;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using UnityEngine;
using UnityEngine.SceneManagement;

//开始运行时加载所有的HybridCLR的HopUpdate的DLL
public class DLLLoader : MonoBehaviour
{
    void Start()
    {
        // Editor环境下，HotUpdate.dll.bytes已经被自动加载，不需要加载，重复加载反而会出问题。
#if !UNITY_EDITOR
        LoadMetadataForAOTAssemblies();
        foreach (DLLLoadCfg cfg in HybridCLRCfg.hotUpdateDLLNames)
        {
            Assembly hotUpdateAss = Assembly.Load(File.ReadAllBytes($"{BasicPathHelper.Instance.PersistentDataPath}/{cfg.dllName}.dll.bytes"));
            if (cfg.afterLoadeAction != null)
            {
                cfg.afterLoadeAction.Invoke(hotUpdateAss);
            }
        }
#else
        //Editor下无需加载，直接查找获得HotUpdate程序集
        foreach (DLLLoadCfg cfg in HybridCLRCfg.hotUpdateDLLNames)
        {
            if (cfg.afterLoadeAction != null)
            {
                Assembly hotUpdateAss = System.AppDomain.CurrentDomain.GetAssemblies().First(a => a.GetName().Name == cfg.dllName);
                cfg.afterLoadeAction.Invoke(hotUpdateAss);
            }
        }
#endif
    }

    //补充元数据 用于泛型
    private void LoadMetadataForAOTAssemblies()
    {
        foreach (var aotDllName in AOTGenericReferences.PatchedAOTAssemblyList)
        {
            byte[] dllBytes = File.ReadAllBytes($"{BasicPathHelper.Instance.PersistentDataPath}/{aotDllName}.bytes");
            LoadImageErrorCode err = RuntimeApi.LoadMetadataForAOTAssembly(dllBytes, HomologousImageMode.SuperSet);
            Debug.Log($"LoadMetadataForAOTAssembly:{aotDllName}. ret:{err}");
        }
    }
}

public static class HybridCLRCfg
{
    public readonly static List<DLLLoadCfg> hotUpdateDLLNames = new List<DLLLoadCfg>
    {
        new DLLLoadCfg("Frame"),
        new DLLLoadCfg("Game",(assembly)=>{
            if (assembly == null)
                return;
            Type launcherType = assembly.GetType("Launcher");
            launcherType.GetMethod("InitGame").Invoke(null, null);
        })      
    };
}

public class DLLLoadCfg
{
    public string dllName { private set; get; }
    public Action<Assembly> afterLoadeAction { private set; get; }

    public DLLLoadCfg(string name, Action<Assembly> cb = null)
    {
        dllName = name;
        afterLoadeAction = cb;
    }
}