using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using UnityEngine;
using UnityEngine.UI;

public class UINBagMapNode : UIBase
{
    [SerializeField]
    private Button openBagButtonUp;
    [SerializeField]
    private Button openBagButtonDown;
    [SerializeField]
    private UINBagMapLevelItem levelItemPrototype;
    [SerializeField]
    private UINBagMapHolder holder;

    private ResLoader resLoader;
    private ObjectPool levelItemPool;
    private Dictionary<Vector2Int, UINBagMapLevelItem> pos2LevelItemDic = new();

    private void Start()
    {
        GameManger.messageCenter.AddListernre(MsgType.onMoveRoom, OnMoveMap);
        openBagButtonUp.onClick.AddListener(OnClickOpenBag);
        openBagButtonDown.onClick.AddListener(OnClickOpenBag);
    }

    public void GenMap(ResLoader resLoader)
    {
        this.resLoader = resLoader;

        //根据数据刷新出地图
        if (levelItemPool == null)
        {
            levelItemPool = new ObjectPool(levelItemPrototype.gameObject);
        }
        EpMap epMap = GameManger.Instance.epCtrl.epMap;

        //计算地图大小
        Vector4 outSize = new Vector4(int.MinValue, int.MinValue, int.MaxValue, int.MaxValue);
        foreach (var room in epMap.roomDic.Values)
        {
            outSize.x = Math.Max(outSize.x, room.Pos.x);
            outSize.y = Math.Max(outSize.y, room.Pos.y);
            outSize.z = Math.Min(outSize.z, room.Pos.x);
            outSize.w = Math.Min(outSize.w, room.Pos.y);
        }
        Vector2 size = new Vector2(outSize.x - outSize.z, outSize.y - outSize.w);
        size *= 150;
        size += new Vector2(200, 200);
        Vector2 leftDownCornor = new Vector2(outSize.z, outSize.w);
        holder.uiTransform.sizeDelta = size;

        levelItemPool.RecycleAll();
        pos2LevelItemDic.Clear();
        //生成item
        foreach (EpRoom room in epMap.roomDic.Values)
        {
            GameObject go = levelItemPool.GetOne();
            UINBagMapLevelItem levelItem = go.GetComponent<UINBagMapLevelItem>();
            Vector3 levelPos = new Vector3((room.Pos.x - outSize.z) * 150 + 50, (room.Pos.y - outSize.w) * 150 + 50, 0);
            levelItem.uiTransform.anchoredPosition = levelPos;

            bool isCurRoom = room == epMap.curRoom;
            bool up = epMap.roomDic.ContainsKey(epMap.Pos2Index(new Vector2Int(room.Pos.x, room.Pos.y + 1)));
            bool right = epMap.roomDic.ContainsKey(epMap.Pos2Index(new Vector2Int(room.Pos.x + 1, room.Pos.y)));
            levelItem.SetInUpAndRightHasOtherRoom(up, right);
            levelItem.InitLevelItem(room);
            levelItem.RefreshLevelItem(isCurRoom, this.resLoader);

            pos2LevelItemDic.Add(room.Pos, levelItem);
        }
    }

    public void RefreshMap()
    {
        EpMap epMap = GameManger.Instance.epCtrl.epMap;
        foreach (var levelItem in pos2LevelItemDic.Values)
        {
            bool isCurRoom = levelItem.room == epMap.curRoom;
            levelItem.RefreshLevelItem(isCurRoom, this.resLoader);
        }
    }

    private void OnMoveMap()
    {
        RefreshMap();
        if (GameManger.Instance.epCtrl.IsInBattle())
        {
            CloseMap();
        }
    }

    private void CloseMap()
    {
        //TODO animation
        Hide();
    }

    private void ShowMap()
    {
        //TODO animation
        Show();
    }

    private void OnClickOpenBag()
    {
        if (gameObject.activeSelf)
            CloseMap();
        else
            ShowMap();
    }

    private void OnDestroy()
    {
        GameManger.messageCenter.RemoveListernre(MsgType.onMoveRoom, OnMoveMap);
    }
}