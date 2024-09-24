using System;
using System.Collections.Generic;

public static class TagRegister
{
    /// <summary>
    /// 所有tag的dic
    /// </summary>
    private static Dictionary<int, Tag> tagDic = new Dictionary<int, Tag>();

    public static void RegistAllTag()
    {
        foreach (TagCfgData cfg in TagCfg.data.Values)
        {
            Tag tag = new Tag(cfg);
            tagDic.Add(cfg.id, tag);
        }
    }

    public static Tag Id2Tag(int id)
    {
        return tagDic[id];
    }
}

public static class TagGroupRegister
{
    private static Dictionary<int, TagGroup> tagGroupDic = new Dictionary<int, TagGroup>();

    public static void RegistAllTagGroup()
    {
        foreach (TagGroupCfgData cfg in TagGroupCfg.data.Values)
        {
            TagGroup tagGroup = new TagGroup(cfg);
            tagGroupDic.Add(cfg.id, tagGroup);
        }
    }

    public static TagGroup Id2TagGroup(int id)
    {
        return tagGroupDic[id];
    }
}