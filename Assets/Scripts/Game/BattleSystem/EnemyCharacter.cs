using System.Data;
using System;
using Game.EnemyAI;
using UnityEngine;

public class EnemyCharacter : Character
{
    public EnemyIntention enemyIntention { private set; get; }
    public Vector2 enemySize { private set; get; }
    public Vector2 enemyCenterOffset { private set; get; }
    private EnemyAIBase enemyAIBase;

    public EnemyCharacter(EnemyCfgData enemyCfgData)
    {
        HP = new CharacterAttribute(enemyCfgData.default_HP);
        MP = new CharacterAttribute(0);
        AP = new CharacterAttribute(0);

        resName = enemyCfgData.res;
        sizeInScene = enemyCfgData.size[0];
        enemySize = new Vector2(enemyCfgData.size[0], enemyCfgData.size[1]);
        enemyCenterOffset = new Vector2(enemyCfgData.center_offset[0], enemyCfgData.center_offset[1]);

        string className = "Game.EnemyAI." + enemyCfgData.script;
        Type classTypr = Type.GetType(className);
        object obj = Activator.CreateInstance(classTypr, new object[] { });
        enemyAIBase = (EnemyAIBase)obj;
        enemyAIBase.BindCharacter(this);
    }
 
    public override void OnTurnStart()
    {
        enemyIntention = enemyAIBase.GenEnemyIntention();
    }

    public override void PlayerTurnOver()
    {
        base.PlayerTurnOver();
        DoIntention();
    }

    /// <summary>
    /// 做出意图
    /// </summary>
    private void DoIntention()
    {
        if (enemyIntention != null)
        {
            var epCtrl = GameManger.Instance.epCtrl;
            epCtrl.battleCtrl.AddEmemyIntention(enemyIntention);
        }
    }
}
