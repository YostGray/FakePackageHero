using System;
using System.Collections;
using System.Runtime.InteropServices.ComTypes;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.UI;

public class UINBagMapLevelItem : UIBase
{
    [SerializeField]
    private Image levelPic;
    [SerializeField]
    private GameObject rightBridge;
    [SerializeField]
    private GameObject upBridge;

    [SerializeField]
    private Button button;

    public EpRoom room { private set; get; }

    private void Start()
    {
        button.onClick.AddListener(OnClick);
    }

    public void InitLevelItem(EpRoom room)
    {
        this.room = room;
    }

    public void RefreshLevelItem(bool isCurRoom, ResLoader resLoader)
    {
        SpriteAtlas bagAtlas = resLoader.Load<SpriteAtlas>(PathHelper.GetAtlasePath("Bag"));
        string resName = room.GetLevelItemResName();
        levelPic.sprite = bagAtlas.GetSprite(resName);

        if (isCurRoom) 
            levelPic.color = Color.white;
        else
            levelPic.color = new Color(0.5f,0.5f,0.5f);
    }

    public void SetInUpAndRightHasOtherRoom(bool up, bool right)
    {
        upBridge.SetActive(up);
        rightBridge.SetActive(right);
    }

    private void OnClick()
    {
        EpMap epMap = GameManger.Instance.epCtrl.epMap;
        epMap.EnterRoom(room);
    }
}