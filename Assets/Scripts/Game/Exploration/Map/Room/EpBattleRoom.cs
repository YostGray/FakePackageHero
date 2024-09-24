using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class EpBattleRoom : EpRoom
{
    List<Character> enemyList;
    public bool IsCleared = false;
    public bool isBoss = false;
    public bool isElit = false;
    private int lootNum;
    private List<int> lootList;
    public EpBattleRoom()
    {
        RoomType = eEpRoomLogicType.battle;
        enemyList = new List<Character>();
    }

    public void InitBattleRoomByBossRoomId(int bossRoomId)
    {
        var bossRoomCfg = BossRoomCfg.data[bossRoomId];
        foreach (int monsterId in bossRoomCfg.monsters)
            AddEnemyById(monsterId);
        isBoss = true;

        lootNum = bossRoomCfg.loot_num;
        lootList = new List<int>(bossRoomCfg.loot_list);
    }

    public void InitBattleRoomByBattleRoomId(int battleRoomId)
    {
        var battleRoomCfg = BattleRoomCfg.data[battleRoomId];
        foreach (int monsterId in battleRoomCfg.monsters)
            AddEnemyById(monsterId);
        isElit = battleRoomCfg.is_elite;

        lootNum = battleRoomCfg.loot_num;
        lootList = new List<int>(battleRoomCfg.loot_list);
    }

    private void AddEnemyById(int monsterId)
    {
        if (EnemyCfg.data.TryGetValue(monsterId, out EnemyCfgData v))
        {
            AddEnemy(new EnemyCharacter(v));
        }
        else
        {
            Debug.LogError($"不存在的怪物配置{monsterId}");
        }
    }

    public void AddEnemy(Character enemy)
    {
        enemyList.Add(enemy);
    }

    //奖励发放
    private void DoLoot()
    {
        var epCtrl = GameManger.Instance.epCtrl;
        var bagCtrl = GameManger.Instance.bagCtrl;

        //没有掉落直接退出
        if (lootNum <= 0)
        {
            epCtrl.ChangeEpState(eEpState.exploring);
            return;
        }

        //处理掉落表
        int[] itemIds, chances;
        {
            const int currentLuck = 0;//TODO 主角的幸运值
            Dictionary<int, int> lootTable = new Dictionary<int, int>();
            foreach (var lootId in lootList)
            {
                int costLuck = 0;
                LootData lootData = LootCfg.data[lootId];
                while (currentLuck - costLuck > lootData.lucky)
                {
                    costLuck += lootData.lucky;
                    lootData = LootCfg.data[lootId];
                }
                for (int i = 0; i < lootData.loot.Length; i++)
                {
                    int itemId = lootData.loot[i];
                    int chance = lootData.loot_chance[i];
                    if (lootTable.ContainsKey(itemId))
                        lootTable[itemId] = lootTable[itemId] + chance;
                    else
                        lootTable.Add(itemId, chance);
                }
            }
            itemIds = lootTable.Keys.ToArray();
            chances = new int[itemIds.Length];
            chances[0] = lootTable[itemIds[0]];
            for (int i = 1; i < itemIds.Length; i++)
            {
                chances[i] = chances[i - 1] + lootTable[itemIds[i]];
            }
        }

        //计算真正的掉落
        int[] resultItems = new int[lootNum];
        {
            int totalChance = chances[itemIds.Length - 1];
            int drawSeed = GameManger.Instance.seed + (Pos.x << 16 | Pos.y);
            System.Random random = new System.Random(drawSeed);
            for (int i = 0; i < lootNum; i++)
            {
                int num = random.Next(totalChance);
                for (int j = 0; j < itemIds.Length; j++)
                {
                    if (num <= chances[j])
                    {
                        resultItems[i] = itemIds[j];
                    }
                }
            }
        }

        //添加到背包
        foreach (int itemId in resultItems)
        {
            ItemCfgData itemCfg = ItemCfg.data[itemId];
            bagCtrl.AddWaitItem(itemCfg);
        }

        epCtrl.ChangeEpState(eEpState.waitAddItem2Bag);
    }

    public override void BeEnter()
    {
        var epCtrl = GameManger.Instance.epCtrl;

        epCtrl.ChangeEpState(eEpState.inBattle);

        epCtrl.battleCtrl = new BattleCtrl();
        epCtrl.battleCtrl.StartBattle(epCtrl.player,enemyList, DoLoot);
    }

    public override void BeLeave()
    {
        var epCtrl = GameManger.Instance.epCtrl;
        //epCtrl.battleCtrl.StopBattle();
        epCtrl.battleCtrl = null;

        //TODO 还有拿东西的流程
        GameManger.Instance.epCtrl.ChangeEpState(eEpState.exploring);
    }

    public override string GetLevelItemResName()
    {
        if (IsCleared)
            return "房间_空房间";
        if (isBoss)
            return "房间_BOSS";
        if (isElit)
            return "房间_精英怪";
        return "房间_普通怪";
    }
}