using System.IO;
using UnityEditor;
using UnityEngine;

public static class HybridCLRHelper
{
    [MenuItem("Extension/Other/一键准备热更新资源", priority = 1)]
    public static void PrepareHotFixRes()
    {
        //优化速度https://hybridclr.doc.code-philosophy.com/docs/basic/buildpipeline
        HybridCLR.Editor.Commands.PrebuildCommand.GenerateAll();
        CopyAndRenameHotUpdateDLL();
        CopyAndRenameSupplyGenericDataDLL();
    }

    [MenuItem("Extension/Other/复制补充元数据DLL")]
    public static void CopyAndRenameSupplyGenericDataDLL()
    {
        BuildTarget target = EditorUserBuildSettings.activeBuildTarget;
        string dllDir = HybridCLR.Editor.SettingsUtil.GetAssembliesPostIl2CppStripDir(target);
        foreach (string name in AOTGenericReferences.PatchedAOTAssemblyList)
        {
            var dllFilePath = Path.Combine(dllDir, name);
            if (File.Exists(dllFilePath))
            {
                var targetPath = Path.Combine(BasicPathHelper.Instance.StreamingAssetsPath, $"{name}.bytes");
                BasicPathHelper.CopyFile(dllFilePath, targetPath);
            }
            else
            {
                Debug.LogError($"无法找到补充元数据程序集:{name}\n查找目录为{dllDir}");
            }
        }
    }

    [MenuItem("Extension/Other/复制热更新DLL")]
    public static void CopyAndRenameHotUpdateDLL()
    {
        BuildTarget target = EditorUserBuildSettings.activeBuildTarget;
        string dllDir = HybridCLR.Editor.SettingsUtil.GetHotUpdateDllsOutputDirByTarget(target);
        foreach (DLLLoadCfg cfg in HybridCLRCfg.hotUpdateDLLNames)
        {
            var dllFilePath = Path.Combine(dllDir, $"{cfg.dllName}.dll");
            if (File.Exists(dllFilePath))
            {
                var targetPath = Path.Combine(BasicPathHelper.Instance.StreamingAssetsPath, $"{cfg.dllName}.dll.bytes");
                BasicPathHelper.CopyFile(dllFilePath, targetPath);
            }
            else
            {
                Debug.LogError($"无法找到补充元数据程序集:{cfg.dllName}\n查找目录为{dllDir}");
            }
        }
    }
}