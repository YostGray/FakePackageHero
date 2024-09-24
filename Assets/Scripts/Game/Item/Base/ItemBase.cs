
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using UnityEngine;

public abstract class ItemBase
{
    public Vector2Int rootPosInBag { set; get; } = new Vector2Int(-1,-1);//负数说明不在背包中
    public ItemCfgData itemCfg { private set; get; }
    public ItemShape shape { private set; get; }
    public bool isInstalled{ private set; get; }

    //物品自己内部的buff
    private List<Buff> itemBuffList { set; get; }

    public ItemBase(ItemCfgData itemCfg)
    {
        this.itemCfg = itemCfg;
        shape = new ItemShape(itemCfg);
        isInstalled = false;
        itemBuffList = new List<Buff>();
    }

    public string GetResName()
    {
        return itemCfg.res;
    }

    public string GetName()
    {
        return itemCfg.name;
    }

    virtual public string GetDes()
    {
        return itemCfg.des;
    }

    virtual public List<Tag> GetTags()
    {
        return itemCfg.DefaultTags;
    }

    virtual public List<ItemFuncData> GetFuncData()
    {
        return ItemHelper.GenFuncData(this);
    }

    /// <summary>
    /// 当被安装到背包
    /// </summary>
    virtual public void OnInstall2Bag(BagCtrl bagCtrl)
    {
        //放入背包就生效的item处理
        if (this is IInBagAddBuffItem addBuffItem)
        {
            GameManger.Instance.epCtrl.player.AddBuff(addBuffItem.GetEffectBuff());
        }

        //对其他物品生效的item处理
        if (this is IEffectNearByItem effectNearByItem)
        {
            var effectShape = effectNearByItem.GetEffectShape();
            var posList = GetBlocks4Shape(effectShape);
            bagCtrl.ModifyItemBuff(effectNearByItem.GetEffectBuff(), posList, true);
        }

        isInstalled = true;
    }

    /// <summary>
    /// 当被从背包卸载
    /// </summary>
    virtual public void OnUninstall2Bag(BagCtrl bagCtrl)
    {
        //放入背包就生效的item处理
        if (this is IInBagAddBuffItem addBuffItem)
        {
            GameManger.Instance.epCtrl.player.RemoveBuff(addBuffItem.GetEffectBuff());
        }

        //对其他物品生效的item处理
        if (this is IEffectNearByItem effectNearByItem)
        {
            var effectShape = effectNearByItem.GetEffectShape();
            var posList = GetBlocks4Shape(effectShape);
            bagCtrl.ModifyItemBuff(effectNearByItem.GetEffectBuff(), posList, false);
        }

        isInstalled = false;
    }

    public Vector2 GetSize()
    {
        return shape.OutLineSize;
    }

    public Vector2 GetPivote()
    {
        return new Vector2((shape.root.x + 0.5f) / (shape.OutLineSize.x), (shape.root.y + 0.5f) / (shape.OutLineSize.y) );
    }

    /// <summary>
    /// 获取占据的方格
    /// </summary>
    public List<Vector2Int> GetBlocks4Shape(ItemShape inputShape = null) 
    {
        if (rootPosInBag.x < 0)
        {
            return null;
        }
        if (inputShape == null)
        {
            inputShape = shape;
        }
        List<Vector2Int> posList = new List<Vector2Int>();
        foreach (Vector2Int posShift in inputShape.Get2RootShiftArray())
        {
            Vector2Int realPos = posShift + rootPosInBag;
            posList.Add(realPos);
        }
        return posList;
    }

    public void AddBuffToItem(Buff buff)
    {
        foreach (var curBuff in itemBuffList)
        {
            if (curBuff.GetType() == buff.GetType())
            {
                curBuff.MergeBuff(buff, true);
                return;
            }
        }
        itemBuffList.Add(buff);
    }

    public void RemoveBuffFromItem(Buff buff)
    {
        foreach (var curBuff in itemBuffList)
        {
            if (curBuff.GetType() == buff.GetType())
            {
                curBuff.MergeBuff(buff, false);
                if (curBuff.level <= 0 || curBuff.lastNum <= 0)
                {
                    itemBuffList.Remove(curBuff);
                }
                break;
            }
        }
    }

    //应用自己的buff
    protected void ApplyItemBuff(ItemUseInfo info)
    {
        foreach (var curBuff in itemBuffList)
        {
            curBuff.Apply2ItemUseInfo(info);
        }
    }


    //当战斗开始
    public virtual void OnBattleStart() { }
    //当战斗结束
    public virtual void OnBattleEnd() { }
}

public class ItemFuncData
{
    public string conditonStr { get; private set; }
    public string desStr { get; private set; }

    public ItemFuncData(string conditonStr, string desStr) 
    {
        this.conditonStr = conditonStr;
        this.desStr = desStr;
    }
}

public static class ItemHelper
{
    static Regex matchValue = new Regex(@"{([^{}]*)}");

    public static List<ItemFuncData> GenFuncData(ItemBase itemData)
    {
        List<ItemFuncData> list = new List<ItemFuncData>();
        string[] lines = itemData.itemCfg.func_des.Split('\n');
        foreach (string line in lines)
        {
            string[] coditonAndDes = line.Split(':');

            string conditonStr = coditonAndDes[0] switch
            {
                "[on_use]" => "主动使用：",
                "[in_bag]" => "放入背包时生效：",
                "[drag]" => "拖动到其它物品上生效：",
                _ => "未定义：",
            };

            string desOrgStr = coditonAndDes[1];
            StringBuilder desStr = new StringBuilder();
            int indexText = 0;
            MatchCollection matchRsult = matchValue.Matches(desOrgStr);
            ItemUseInfo itemUseInfo = GameManger.Instance.bagCtrl.CalItemUseInfo(itemData);
            for (int i = 0; i < matchRsult.Count; i++)
            {
                Match match = matchRsult[i];
                if (!match.Success) { continue; }

                desStr.Append(desOrgStr.Substring(indexText, match.Index - indexText));
                indexText = match.Index + match.Length;

                Group inside = match.Groups[1];
                if (!inside.Success) { continue; }
                switch (inside.Value)
                {
                    case "c_s":
                        desStr.Append(itemUseInfo.costInfo.costAp.ToString() + "点体力");
                        break;
                    case "d":
                        desStr.Append(itemUseInfo.atkInfo.dmgNum.ToString());
                        break;
                    default:
                        break;
                }
            }
            desStr.Append(desOrgStr.Substring(indexText, desOrgStr.Length - indexText));

            ItemFuncData data = new ItemFuncData(conditonStr, desStr.ToString());
            list.Add(data);
        }
        return list;
    }
}