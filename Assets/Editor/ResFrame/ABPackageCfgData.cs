using System.Collections;
using System.Collections.Generic;

/// <summary>
/// AB包配置数据类
/// </summary>
[System.Serializable]
public class ABPackageCfgData
{
    public string name;//此规则的名字
    public bool isUsing = true;//是否启用此打包规则
    public ePackWay packWay = ePackWay.none;//打包方式
    public eManifestWriteType manifestWriteType = eManifestWriteType.writeAll;

    public string assetDir;//资源的搜索根目录
    public string searchePattern;//搜索通配符
    public bool isRecursionSearch = true;//是否递归的搜索(total不适用)
    public bool isForceIncludeDepends = false;//是否强制包含依赖(优先用它)
    public bool isIncludeTopDir = false;//是否包含顶层目录(eachFolder适用)
}

/// <summary>
/// 打包方式
/// </summary>
public enum ePackWay
{
    none = 0,//未定义
    eachFile = 1,//每个文件一个ab
    eachFolder = 2,//每个文件夹一个ab
    total = 3,//整个根目录一个ab
}

/// <summary>
/// 清单写入方式
/// TODO:不大懂，再学学 似乎和图集之类的文件相关
/// </summary>
public enum eManifestWriteType
{
    writeAll = 0,//写入全部
}