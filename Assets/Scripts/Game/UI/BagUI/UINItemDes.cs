using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using UnityEngine;
using UnityEngine.UI;

public class UINItemDes : UIBase
{
    [SerializeField]
    private ExText itemName;
    [SerializeField]
    private ExText des;
    [SerializeField]
    private GameObject itemTag;
    [SerializeField]
    private GameObject desNode;

    ObjectPool tagPool;
    ObjectPool funDesPool;

    public override void Awake()
    {
        tagPool = new ObjectPool(itemTag);
        funDesPool = new ObjectPool(desNode);
        base.Awake();
    }

    public void Refresh(ItemBase item)
    {
        itemName.text = item.GetName();
        des.text = item.GetDes();

        tagPool.RecycleAll();   
        foreach (Tag tag in item.GetTags()) {
            GameObject tagItem = tagPool.GetOne();
            var text = tagItem.GetComponent<ExText>();
            text.text = tag.TagName;
        }

        funDesPool.RecycleAll();
        foreach (ItemFuncData data in item.GetFuncData())
        {
            GameObject desNodeItem = funDesPool.GetOne();
            UINItemDesNode node= desNodeItem.GetComponent<UINItemDesNode>();
            node.RefreshByItemFuncData(data);
        }
    }
}
