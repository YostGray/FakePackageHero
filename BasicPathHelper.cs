using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class BasicPathHelper : Singleton<BasicPathHelper>
{
    //����ƽ̨��StreamAssets·��
    public string StreamingAssetsPath { private set; get; }

    //����ƽ̨��StreamAssets��WWW���ط�ʽ��·��
    public string StreamingAssetsPathForWWW { private set; get; }

    //����ƽ̨��PersistentDataPath·��,�ɶ�д
    public string PersistentDataPath { private set; get; }

    //����ƽ̨��PersistentDataPath��WWW���ط�ʽ��·��,�ɶ�д
    public string PersistentDataPathForWWW { private set; get; }

    protected override void Initialize()
    {
#if UNITY_EDITOR
        //�༭��ģʽ��
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