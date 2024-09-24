using System;
using System.Collections;
using System.Runtime.InteropServices.ComTypes;
using UnityEngine;
using UnityEngine.UI;

public class UINSlotItem : UIBase
{
    private static Color hoverClolor = new Color(0.6f,1,0.6f);
    private static Color hoverNotFitClolor = new Color(1, 0.6f, 0.6f);
    private static Color haveColor = new Color(0.8f, 0.8f, 0.8f);

    //坐标作为唯一交互Key
    public int coordinate { private set; get; }
    [SerializeField]
    public Image slotImg;

    private bool isHaveItem;
    private bool isHover;
    private ItemBase hoverItemBase;
    private BagCtrl bagCtrl;


    public override void Awake()
    {
        base.Awake();
    }

    public void InitByData(BagSlotData slotData)
    {
        this.coordinate = slotData.coordinate;
        bagCtrl = GameManger.Instance.bagCtrl;
        RefreshSlotState();
    }

    public void SetIsHaveItem(bool isHaveItem)
    {
        this.isHaveItem = isHaveItem;
        RefreshSlotState();
    }

    public void SetIsHoverByItem(bool isHover, ItemBase hoverItemBase)
    {
        this.isHover = isHover;
        this.hoverItemBase = hoverItemBase;
        RefreshSlotState();
    }

    public void RefreshSlotState()
    {
        BagSlotData slotData = bagCtrl.slotDic[coordinate];
        if (!slotData.isUnlocked)
        {
            slotImg.color = Color.gray;
            return;
        }
        if (isHover)//悬挂中
        {
            if (slotData.itemData != null && slotData.itemData != hoverItemBase)//格子不合适
            {
                slotImg.color = hoverNotFitClolor;
                return;
            }
            slotImg.color = hoverClolor;
            return;
        }
        if (isHaveItem)
        {
            slotImg.color = haveColor;
            return;
        }
        slotImg.color = Color.white;
    }
}