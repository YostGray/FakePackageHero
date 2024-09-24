using DG.Tweening;
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;

public class CharacterEntity : MonoBehaviour,IPointerClickHandler
{
    [SerializeField]
    public GameObject infoHolder;
    [SerializeField]
    private Animator animator;

    public Character character {  get; set; }

    float atkClipLength = 0.5f;
    float beAtkClipLength = 0.5f;

    private void Awake()
    {
        AnimationClip[] clips = animator.runtimeAnimatorController.animationClips;
        foreach (AnimationClip clip in clips)
        {
            switch (clip.name)
            {
                case "atk":
                    atkClipLength = clip.length;
                    break;
                case "beAtk":
                    beAtkClipLength = clip.length;
                    break;
                default:
                    break;
            }
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        GameManger.Instance.epCtrl.battleCtrl.SetSelectedEmemy(character);
    }

    public float PlayAtkAnmation(AttackInfo atkInfo, Character target)
    {
        if (target == null || target.entity == null)
            return 0.0f;
        switch (atkInfo.attackShow)
        {
            case AttackShowEnum.none:
            case AttackShowEnum.close:
                float oldPosx = this.transform.position.x;
                this.transform.DOMoveX(target.entity.transform.position.x, 0.1f).SetEase(Ease.InBack);
                this.transform.DOMoveX(oldPosx, 0.15f).SetDelay(0.15f).SetEase(Ease.OutBack);
                break;
            case AttackShowEnum.remote:
                break;
            default:
                break;
        }
        animator.SetTrigger("atk");
        return atkClipLength;
    }

    public float PlayBeAtkAnmation()
    {
        animator.SetTrigger("beAtk");
        return beAtkClipLength;
    }

    //给别人加buff
    public float PlayAddBuffAnmation(AddBuffInfo addBuffInfo, Character character)
    {
        Debug.Log("TODO add buff fx");
        return 0.5f;
    }

    //被加buff
    public float PlayBeAddBuffAnmation(AddBuffInfo addBuffInfo, Character character)
    {
        Debug.Log("TODO be add buff fx");
        return 0.5f;
    }

    public float PlayDeadAnmation()
    {
        animator.SetTrigger("dead");
        return beAtkClipLength;
    }
}
