using Codice.Client.BaseCommands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

/// <summary>
/// 探索的地图
/// </summary>
public class EpMap
{
    /// <summary>
    /// 配置数据
    /// </summary>
    private StageCfgData stageCfgData;

    /// <summary>
    /// 当前的房间
    /// </summary>
    public EpRoom curRoom { private set; get; }
    /// <summary>
    /// 房间列表 key为x + maxX * y
    /// </summary>
    public Dictionary<int, EpRoom> roomDic { private set; get; }

    public EpMap(StageCfgData stageCfgData)
    {
        this.stageCfgData = stageCfgData;
        roomDic = GenRandomMap(stageCfgData,out EpRoom firstRoom);
        EnterRoom(firstRoom);
    }

    public void EnterRoom(EpRoom room)
    {
        if (curRoom == room)
            return;
        if (curRoom != null)
            curRoom.BeLeave();
        curRoom = room;
        room.BeEnter();
        GameManger.messageCenter.BroadCast(MsgType.onMoveRoom);
    }

    public Dictionary<int,EpRoom> GenRandomMap(StageCfgData stageCfgData,out EpRoom firstRoom)
    {
        int maxX = stageCfgData.max_size[0];
        int maxY = stageCfgData.max_size[1];


        System.Random random = new System.Random(GameManger.Instance.mapSeed);

        Vector2Int startPos = new Vector2Int(random.Next(maxX), random.Next(maxY));
        int index = Pos2Index(startPos, maxX);
        EpStartRoom room = new EpStartRoom();
        room.Pos = startPos;
        firstRoom = room;

        Vector2Int[] dir = { 
            new Vector2Int(1,0),
            new Vector2Int(0,1),
            new Vector2Int(-1,0),
            new Vector2Int(0,-1),
        };

        int retryMaxTime = 5;
        int currentRoomNum = 1;
        Queue<EpRoom> queue = new Queue<EpRoom>();
        List<EpRoom> endRooms = new List<EpRoom>();//死胡同房间
        Dictionary<int, EpRoom> roomDic = new Dictionary<int, EpRoom>();
        while (currentRoomNum < stageCfgData.room_num) 
        {
            currentRoomNum = 1;

            queue.Clear();
            endRooms.Clear();
            roomDic.Clear();

            queue.Enqueue(room);
            roomDic[index] = room;

            while (queue.Count > 0 && currentRoomNum < stageCfgData.room_num)
            {
                EpRoom curRoom = queue.Dequeue();
                Vector2Int pos = curRoom.Pos;

                bool isAddedRoom = false;
                foreach (var d in dir)
                {
                    Vector2Int neighborPos = d + pos;

                    //不能出界
                    if (neighborPos.x >= maxX || neighborPos.x < 0 || neighborPos.y >= maxY || neighborPos.y < 0)
                        continue;

                    int neighborIndex = Pos2Index(neighborPos, maxX);

                    //是否已经有房间
                    if (roomDic.ContainsKey(neighborIndex))
                        continue;

                    //是否超过一个邻接
                    int n2Num = 0;
                    foreach (var d2 in dir)
                    {
                        Vector2Int n2Pos = d2 + neighborPos;
                        int n2Index = Pos2Index(n2Pos, maxX);
                        if (roomDic.ContainsKey(n2Index))
                            n2Num++;
                    }
                    if (n2Num > 1)
                        continue;

                    //50%概率直接不要
                    var giveUpChance = random.Next(100);
                    if (giveUpChance > 50)
                        continue;

                    var battleRoomId = stageCfgData.battle_room_pool[random.Next(stageCfgData.battle_room_pool.Count())];

                    EpBattleRoom battleRoom = new EpBattleRoom();
                    battleRoom.Pos = neighborPos;
                    battleRoom.InitBattleRoomByBattleRoomId(battleRoomId);
                    int roomIndex = Pos2Index(neighborPos, maxX);
                    roomDic[roomIndex] = battleRoom;
                    queue.Enqueue(battleRoom);
                    isAddedRoom = true;
                    currentRoomNum++;
                }
                if (!isAddedRoom)
                {
                    endRooms.Add(curRoom);
                }
            }

            if (retryMaxTime-- < 0)
            {
                Debug.LogWarning("地图生成重试次数过多，请检查约束是否太严格");
                break;
            }
        }

        var change2BossInde = random.Next(endRooms.Count);
        var change2BossRoom = endRooms[change2BossInde];
        EpBattleRoom bossRoom = new EpBattleRoom();
        bossRoom.Pos = change2BossRoom.Pos;
        int bossRoomId = stageCfgData.boss_room;
        bossRoom.InitBattleRoomByBossRoomId(bossRoomId);
        roomDic[Pos2Index(bossRoom.Pos,maxX)] = bossRoom;

        return roomDic;
    }

    public int Pos2Index(Vector2Int pos,int max_x)
    {
        return pos.x + pos.y * max_x;
    }

    public int Pos2Index(Vector2Int pos)
    {
        return Pos2Index(pos, stageCfgData.max_size[0]);
    }
}