using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ABMidData
{
    public string ABName;//ab文件名
    public HashSet<string> assetNameSet = new HashSet<string>();//资源路径集合
    public HashSet<string> forceAssetNameSet = new HashSet<string>();//强制包含依赖的资源路径集合
    public List<string> dependencies = new List<string>();//依赖的资源的ab包名
    public eManifestWriteType manifestWriteType = eManifestWriteType.writeAll;//如何写入manifest

    public bool isSharedAB = false;//是否是共享AB包
    public bool isForceIncludeDepends = false;//是否强制包含依赖(优先用它)
}
