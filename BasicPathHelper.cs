using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class BasicPathHelper : Singleton<BasicPathHelper>
{
    //各个平台的StreamAssets路径
    public string StreamingAssetsPath { private set; get; }

    //各个平台的StreamAssets的WWW加载方式的路径
    public string StreamingAssetsPathForWWW { private set; get; }

    //各个平台的PersistentDataPath路径,可读写
    public string PersistentDataPath { private set; get; }

    //各个平台的PersistentDataPath的WWW加载方式的路径,可读写
    public string PersistentDataPathForWWW { private set; get; }

    protected override void Initialize()
    {
#if UNITY_EDITOR
        //编辑器模式下
        var assetPath = Path.GetDirectoryName(Application.dataPath);
        StreamingAssetsPathForWWW = string.Format("file://{0}/StreamingAssets/", Application.dataPath);
        StreamingAssetsPath = string.Format("{0}/StreamingAssets/", Application.dataPath);
        PersistentDataPathForWWW = string.Format("file://{0}/EditorPersistent/", assetPath);
        PersistentDataPath = string.Format("{0}/EditorPersistent/", assetPath);
#elif UNITY_STANDALONE_WIN
        StreamingAssetsPathForWWW = string.Format("file:///{0}/StreamingAssets/", Application.dataPath);
        StreamingAssetsPath = string.Format("{0}/StreamingAssets/", Application.dataPath);
        PersistentDataPathForWWW = string.Format("file:///{0}/StreamingAssets/", Application.dataPath);
        PersistentDataPath = string.Format("{0}/StreamingAssets/", Application.dataPath);
#elif UNITY_ANDROID
        StreamingAssetsPathForWWW = string.Format("jar:file://{0}!/assets/", Application.dataPath);
        StreamingAssetsPath = string.Concat(Application.streamingAssetsPath, "/");
        PersistentDataPathForWWW = string.Format("file://{0}/", Application.persistentDataPath);
        PersistentDataPath = string.Concat(Application.persistentDataPath,"/");
#elif UNITY_IOS
        StreamingAssetsPathForWWW = string.Format("file://{0}/Raw/", Application.dataPath);
        StreamingAssetsPath = string.Format("{0}/Raw/", Application.dataPath);
        PersistentDataPathForWWW = string.Format("file://{0}/", Application.persistentDataPath);
        PersistentDataPath = string.Concat(Application.persistentDataPath,"/");
#endif
    }

    public static string GetResPlatformName()
    {
#if UNITY_STANDALONE_WIN
        return "Windows";
#elif UNITY_STANDALONE_OSX
        return "OSX";
#elif UNITY_ANDROID
        return "Android";
#elif UNITY_IOS
        return "iOS";
#endif
    }
}