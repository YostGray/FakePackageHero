
using UnityEngine;
/// <summary>
/// 标签
/// </summary>
public struct Tag
{
    private TagCfgData cfg;
    public Tag(TagCfgData cfg)
    {
        this.cfg = cfg;
    }

    public readonly string TagName => cfg.name;
}
