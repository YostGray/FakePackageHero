using Assets.Scripts.Game.UI.BattleInfoUI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class BattleShowCtrl
{
    private UIBattleInfo battleInfoWin;

    public BattleShowCtrl()
    {
        battleInfoWin = UIManager.Instance.GetWindow<UIBattleInfo>("UI_BattleInfo");
    }

    public void RefreshUI()
    {
        battleInfoWin?.OnBattleLogicUpdate();
    }

    public IEnumerator ShowAtk(AttackInfo atkInfo)
    {
        var casterEntity = atkInfo.caster.entity;
        float waitTime = casterEntity.PlayAtkAnmation(atkInfo, atkInfo.targets[0]);
        for (int i = 0; i < atkInfo.targets.Count; i++)
        {
            Character target = atkInfo.targets[i];
            waitTime = Math.Max(waitTime, target.entity.PlayBeAtkAnmation());
        }
        yield return null;
        battleInfoWin?.OnBattleLogicUpdate();
        yield return new WaitForSeconds(waitTime);
    }

    public IEnumerator ShowAddBuff(AddBuffInfo addBuffInfo)
    {
        var casterEntity = addBuffInfo.caster.entity;
        float waitTime = casterEntity.PlayAddBuffAnmation(addBuffInfo, addBuffInfo.caster);
        for (int i = 0; i < addBuffInfo.targets.Count; i++)
        {
            Character target = addBuffInfo.targets[i];
            waitTime = Math.Max(waitTime, target.entity.PlayBeAddBuffAnmation(addBuffInfo, target));
        }
        yield return null;
        battleInfoWin?.OnBattleLogicUpdate();
        yield return new WaitForSeconds(waitTime);
    }

    public IEnumerator ShowDead(Character player)
    {
        var entiy = player.entity;
        float waitTime = entiy.PlayDeadAnmation();
        yield return null;
        battleInfoWin?.OnBattleLogicUpdate();
        yield return new WaitForSeconds(waitTime);
    }
}