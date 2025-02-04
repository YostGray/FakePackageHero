using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class BasicPathHelper
{
	private static BasicPathHelper m_instance;
	public static BasicPathHelper Instance
	{
		get
		{
			if (m_instance == null)
			{
				m_instance = new BasicPathHelper();
				m_instance.Initialize();
			}
			return m_instance;
		}
	}

	//各个平台的StreamAssets路径
	public string StreamingAssetsPath { private set; get; }

	//各个平台的StreamAssets的WWW加载方式的路径
	public string StreamingAssetsPathForWWW { private set; get; }

	//各个平台的PersistentDataPath路径,可读写
	public string PersistentDataPath { private set; get; }

	//各个平台的PersistentDataPath的WWW加载方式的路径,可读写
	public string PersistentDataPathForWWW { private set; get; }

	protected void Initialize()
	{

#if UNITY_STANDALONE_WIN && !UNITY_EDITOR
        StreamingAssetsPathForWWW = string.Format("file:///{0}/StreamingAssets/", Application.dataPath);
        StreamingAssetsPath = string.Format("{0}/StreamingAssets/", Application.dataPath);
        PersistentDataPathForWWW = string.Format("file:///{0}/StreamingAssets/", Application.dataPath);
        PersistentDataPath = string.Format("{0}/StreamingAssets/", Application.dataPath);
#elif UNITY_ANDROID && !UNITY_EDITOR
        StreamingAssetsPathForWWW = string.Format("jar:file://{0}!/assets/", Application.dataPath);
        StreamingAssetsPath = string.Concat(Application.streamingAssetsPath, "/");
        PersistentDataPathForWWW = string.Format("file://{0}/", Application.persistentDataPath);
        PersistentDataPath = string.Concat(Application.persistentDataPath,"/");
#elif UNITY_IOS && !UNITY_EDITOR
        StreamingAssetsPathForWWW = string.Format("file://{0}/Raw/", Application.dataPath);
        StreamingAssetsPath = string.Format("{0}/Raw/", Application.dataPath);
        PersistentDataPathForWWW = string.Format("file://{0}/", Application.persistentDataPath);
        PersistentDataPath = string.Concat(Application.persistentDataPath,"/");
#else
		//编辑器模式下
		var assetPath = Path.GetDirectoryName(Application.dataPath);
		StreamingAssetsPathForWWW = string.Format("file://{0}/StreamingAssets/", Application.dataPath);
		StreamingAssetsPath = string.Format("{0}/StreamingAssets/", Application.dataPath);
		PersistentDataPathForWWW = string.Format("file://{0}/EditorPersistent/", assetPath);
		PersistentDataPath = string.Format("{0}/EditorPersistent/", assetPath);
#endif
	}

	public string GetPersistentDataPath(string path)
	{
		return string.Concat(PersistentDataPath, path);
	}

	public string GetStreamingPathForWWW(string path)
	{
		return string.Concat(StreamingAssetsPathForWWW, path);
	}

	public static bool DeleteDir(string srcPath, bool includeSrcPath = true, HashSet<string> excludePath = null)
	{
		try
		{
			DirectoryInfo dir = new DirectoryInfo(srcPath);
			if (!dir.Exists)
				return true;

			FileSystemInfo[] fileinfo = dir.GetFileSystemInfos();  //返回目录中所有文件和子目录
			foreach (FileSystemInfo i in fileinfo)
			{
				if (excludePath != null && excludePath.Contains(i.Name))
					continue;

				if (i is DirectoryInfo)            //判断是否文件夹
				{
					if (!includeSrcPath && i.FullName == srcPath)
						continue;

					var subdir = new DirectoryInfo(i.FullName);
					subdir.Delete(true);          //删除子目录和文件
				}
				else
				{
					//如果 使用了 streamreader 在删除前 必须先关闭流 ，否则无法删除 sr.close();
					File.Delete(i.FullName);      //删除指定文件
				}
			}
		}
		catch (Exception e)
		{
			Debug.LogError(e);
			return false;
		}

		return true;
	}

    public static bool DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs, Action<FileInfo> afterCopyFileAction = null)
    {
        // Get the subdirectories for the specified directory.
        var dir = new DirectoryInfo(sourceDirName);

        if (!dir.Exists)
        {
            Debug.LogError("Source directory doesn't exist");
            return false;
        }

        var dirs = dir.GetDirectories();

        // If the destination directory doesn't exist, create it. 
        if (!Directory.Exists(destDirName))
            Directory.CreateDirectory(destDirName);

        // Get the files in the directory and copy them to the new location.
        var files = dir.GetFiles();
        foreach (var file in files)
        {
            var tempPath = Path.Combine(destDirName, file.Name);
            var newFile = file.CopyTo(tempPath, true);
            afterCopyFileAction?.Invoke(newFile);
        }

        // If copying subdirectories, copy them and their contents to new location. 
        if (copySubDirs)
        {
            foreach (var subDir in dirs)
            {
                var tempPath = Path.Combine(destDirName, subDir.Name);
                DirectoryCopy(subDir.FullName, tempPath, true, afterCopyFileAction);
            }
        }

        return true;
    }

    /// <summary>
    /// 拷贝文件
    /// </summary>
    /// <returns></returns>
    public static bool CopyFile(string srcPath, string tarPath)
    {
        try
        {
            var dirPath = Path.GetDirectoryName(tarPath);
            if (!Directory.Exists(dirPath))
                Directory.CreateDirectory(dirPath);
            else if (File.Exists(tarPath))
                File.Delete(tarPath); //覆盖

            File.Copy(srcPath, tarPath);
        }
        catch (Exception e)
        {
            Debug.LogError(e);
            return false;
        }

        return true;
    }

    public static bool MoveDir(string srcPath, string tarPath)
    {
        try
        {
            var dir = new DirectoryInfo(srcPath);
            if (!dir.Exists)
            {
                Debug.LogError("Source directory doesn't exist");
                return false;
            }

            if (!Directory.Exists(tarPath))
                Directory.CreateDirectory(tarPath);

            var files = dir.GetFiles();
            foreach (var file in files)
            {
                var tarFilePath = Path.Combine(tarPath, file.Name);
                //覆盖
                MoveFile(file.FullName, tarFilePath, false);
            }

            var dirs = dir.GetDirectories();
            foreach (var temDir in dirs)
            {
                var temTargetPath = Path.Combine(tarPath, temDir.Name);
                MoveDir(temDir.FullName, temTargetPath);
            }

            TryMoveMeta(srcPath, tarPath);
            Directory.Delete(srcPath, true);
        }
        catch (Exception e)
        {
            Debug.LogError(e);
            return false;
        }

        return true;
    }

    /// <summary>
    /// 移动文件
    /// </summary>
    /// <param name="srcPath"></param>
    /// <param name="tarPath"></param>
    /// <param name="includeMeta"></param>
    /// <returns></returns>
    public static bool MoveFile(string srcPath, string tarPath, bool includeMeta)
    {
        try
        {
            var dirPath = Path.GetDirectoryName(tarPath);
            if (!Directory.Exists(dirPath))
                Directory.CreateDirectory(dirPath);
            else if (File.Exists(tarPath))
                File.Delete(tarPath); //覆盖

            File.Move(srcPath, tarPath);

            if (includeMeta)
                TryMoveMeta(srcPath, tarPath);
        }
        catch (Exception e)
        {
            Debug.LogError(e);
            return false;
        }

        return true;
    }

    /// <summary>
    /// 尝试移动srcPath 的 meta文件
    /// </summary>
    /// <param name="srcPath"></param>
    /// <param name="tarPath"></param>
    /// <returns></returns>
    public static void TryMoveMeta(string srcPath, string tarPath)
    {
        var metaPath = $"{srcPath}.meta";
        if (File.Exists(metaPath))
        {
            var targetMetaPath = $"{tarPath}.meta";
            MoveFile(metaPath, targetMetaPath, false);
        }
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