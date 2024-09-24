using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

/// <summary>
/// AB����������
/// </summary>
[System.Serializable]
public class GeneratorCfgData
{
    public string ABExtension = ".ab";
    public readonly string ABPackageCfgsJsonPath = Path.Combine(Application.dataPath, "Editor", "ABCfg", "ABCfg.json");
    public readonly string ABStorePath = Path.Combine(Directory.GetParent(Application.dataPath).FullName, "AssetsBundle");//�������洢λ��
    public readonly string ABCopyPath = Path.Combine(Application.streamingAssetsPath, "AssetsBundle");//�����������洢λ��
    public bool isWarnAutoDepBundleSize = true;//�Ƿ񾯸��Զ������ռ�����С
    public float warnAutoDepBundleFileSize_KB = 1024.0f;//�����Զ������ռ�����С(��λKB)

    ///��ȡ�ļ�ʱ ��Ҫ���Ե��ļ���׺��
    public List<string> notCollectFileExtensions = new List<string>();
    ///��ȡ�ļ�ʱ ��Ҫ���Ե��ļ���
    public List<string> notCollectDirFullName = new List<string>();
    ///�ռ�����ʱ ��Ҫ���Ե��ļ���׺��
    public List<string> notCollectFileExtensions_Dependencies = new List<string>();
    ///�ռ�����ʱ ��Ҫ���Եı��������ļ���׺��
    public List<string> notCollectFileExtensions_Dependencies_Dep= new List<string>();

    ///���ѡ��
    public BuildAssetBundleOptions buildAssetBundleOptions = BuildAssetBundleOptions.ChunkBasedCompression | BuildAssetBundleOptions.ForceRebuildAssetBundle;
    ///���Ŀ��ƽ̨
    public BuildTarget buildTarget = EditorUserBuildSettings.activeBuildTarget;
    ///�Ƿ�������Ŀ¼
    public bool isCleanOutputDir = true;
    ///������SteamingAssets
    public bool copy2SteamingAssets = false;
}

