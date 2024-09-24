using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleCtrl
{
    public Character player;
    public List<Character> enemyList;
    public Character selectedCharacter;//选中的角色(一般都是敌人)
    public System.Random battleRandom { private set; get; }

    private Queue<ItemUseInfo> useInfoQueue;
    private Queue<EnemyIntention> enemyIntentionQueue;
    private IEnumerator running;
    private IEnumerator waiting2NextTurn;
    private BattleShowCtrl battleShowCtrl;
    private uint turnNum = 0;
    private Action winCallback;

    public BattleCtrl()
    {
        enemyList = new List<Character>();
        useInfoQueue = new Queue<ItemUseInfo>();
        enemyIntentionQueue = new Queue<EnemyIntention>();
        battleRandom = new System.Random(Time.frameCount);
    }

    public void StartBattle(Character player, List<Character> enemyList, Action winCallback = null)
    {
        battleShowCtrl = new BattleShowCtrl();
        this.player = player;
        this.enemyList.AddRange(enemyList);//拷贝enemy的引用
        this.winCallback = winCallback;
        turnNum = 0;
        GenAllEnemies();
        EnterNewTurn();
        //默认选中第一个选中角色
        selectedCharacter = enemyList[0];
    }

    public void StopBattle()
    {
        if (running != null)
        {
            MonoDriver.Instance.StopCoroutine(running);
        }
        enemyList.Clear();
        selectedCharacter = null;
    }

    /// <summary>
    /// 进入一个回合
    /// </summary>
    private void EnterNewTurn()
    {
        ++turnNum;
        player.OnTurnStart();
        foreach (Character enemy in enemyList)
        {
            enemy.OnTurnStart();
        }
        if (selectedCharacter == null)
        {
            selectedCharacter = enemyList[0];
        }
        GameManger.messageCenter.BroadCast(MsgType.onEnterNewTurn);
    }

    /// <summary>
    /// 回合结束
    /// </summary>
    public void PlayerTurnOver()
    {
        player.PlayerTurnOver();
        foreach (Character enemy in enemyList)
        {
            enemy.PlayerTurnOver();
        }
        waiting2NextTurn = Waiting2NextTurn();
        MonoDriver.Instance.StartCoroutine(waiting2NextTurn);
    }

    private IEnumerator Waiting2NextTurn()
    {
        while (running != null)
        {
            yield return null;
        }
        EnterNewTurn();
        battleShowCtrl.RefreshUI();
        waiting2NextTurn = null;
    }

    public void BattleWin()
    {
        Debug.Log("WIN");
        StopBattle();
        winCallback?.Invoke();
    }
    public void BattleLost()
    {
        Debug.Log("LOST");
        StopBattle();
    }

    public void AddItemUseIfon(ItemUseInfo useInfo)
    {
        if (useInfo == null)
            return;
        useInfoQueue.Enqueue(useInfo);
        if (running == null)
        {
            running = RunAllInfo();
            MonoDriver.Instance.StartCoroutine(running);
        }
    }

    public void AddEmemyIntention(EnemyIntention enemyIntention)
    {
        enemyIntentionQueue.Enqueue(enemyIntention);
        if (running == null)
        {
            running = RunAllInfo();
            MonoDriver.Instance.StartCoroutine(running);
        }
    }

    /// <summary>
    /// 阻塞形式的运行一个个效果info
    /// </summary>
    private IEnumerator RunAllInfo() 
    {
        while (useInfoQueue.TryDequeue(out ItemUseInfo useInfo))
        {
            if (useInfo.addBuffInfo != null)
            {
                for (int i = 0; i < useInfo.addBuffInfo.targets.Count; i++)
                {
                    Character target = useInfo.addBuffInfo.targets[i];
                    target.BeAddBuff(useInfo.addBuffInfo);
                }
                yield return battleShowCtrl.ShowAddBuff(useInfo.addBuffInfo);
                yield return DealAndShowDead();
            }
            if (useInfo.atkInfo != null)
            {
                for (int i = 0; i < useInfo.atkInfo.targets.Count; i++)
                {
                    Character target = useInfo.atkInfo.targets[i];
                    target.BeAttack(useInfo.atkInfo);
                }
                yield return battleShowCtrl.ShowAtk(useInfo.atkInfo);
                yield return DealAndShowDead();
            }
        }

        while (enemyIntentionQueue.TryDequeue(out EnemyIntention enemyIntention))
        {
            if (enemyIntention.addBuffInfos != null)
            {
                foreach (var addBuffInfo in enemyIntention.addBuffInfos)
                {
                    for (int i = 0; i < addBuffInfo.targets.Count; i++)
                    {
                        Character target = addBuffInfo.targets[i];
                        target.BeAddBuff(addBuffInfo);
                    }
                    yield return battleShowCtrl.ShowAddBuff(addBuffInfo);
                    yield return DealAndShowDead();
                }
            }
            if (enemyIntention.attackInfos != null)
            {
                foreach (var atkInfo in enemyIntention.attackInfos)
                {
                    for (int i = 0; i < atkInfo.targets.Count; i++)
                    {
                        Character target = atkInfo.targets[i];
                        target.BeAttack(atkInfo);
                    }
                    yield return battleShowCtrl.ShowAtk(atkInfo);
                    yield return DealAndShowDead();
                }
            }
        }

        running = null;
    }

    /// <summary>
    /// 处理并展示死亡
    /// </summary>
    private IEnumerator DealAndShowDead()
    {
        if (!player.isAlive)
        {
            yield return battleShowCtrl.ShowDead(player);
            BattleLost();
        }
        else
        {
            bool isAllDead = true;
            List<Character> waitRemoveList = new List<Character>();
            foreach (Character e in enemyList)
            {
                if (e.isAlive)
                {
                    isAllDead = false;
                }
                else
                {
                    yield return battleShowCtrl.ShowDead(e);
                    GameObject.Destroy(e.entity.gameObject);
                    waitRemoveList.Add(e);  
                }
            }
            if (waitRemoveList.Count > 0) 
            {
                foreach (Character e in waitRemoveList)
                {
                    if(selectedCharacter == e)
                        selectedCharacter = null;
                    enemyList.Remove(e);
                }
            }
            if (isAllDead)
            {
                BattleWin();
            }
        }
    }

    public void SetSelectedEmemy(Character c)
    {
        if (running == null && waiting2NextTurn == null)
        {
            selectedCharacter = c;
            battleShowCtrl.RefreshUI();
        }
    }

    private void GenAllEnemies()
    {
        float allSizeInScene;

        allSizeInScene = 0;
        foreach (var enemy in enemyList)
        {
            allSizeInScene += enemy.sizeInScene;
        }

        float place_x = -allSizeInScene / 2;
        int waitInitNum = enemyList.Count;
        for (int i = 0; i < enemyList.Count; i++)
        {
            Character c = enemyList[i];
            GameManger.Instance.epCtrl.SwapNewEmemyEntity(c, new Vector3(place_x, 0, 0), () =>{
                --waitInitNum;
                if (waitInitNum == 0)
                    GameManger.messageCenter.BroadCast(MsgType.onMonsterSwapEnd);
            });
            place_x += c.sizeInScene;
        }
    }
}