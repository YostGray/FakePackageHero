using System.Collections.Generic;

public class RustIron : ItemBase, IEffectNearByItemWhenBattleEnd
{
    public RustIron(ItemCfgData itemCfg) : base(itemCfg)
    {

    }
    public override void OnBattleEnd()
    {
        GameManger.Instance.bagCtrl.UninstallItem(this);
    }
    void IEffectNearByItemWhenBattleEnd.AddBuff2ItemList(List<ItemBase> items)
    {
        foreach (var item in items)
        {
            Buff buff = new ItemAddDmgBuff(1);
            item.AddBuffToItem(buff);   
        }
    }
    ItemShape IEffectNearByItemWhenBattleEnd.GetEffectShape()
    {
        return ItemShape.Near4shap;
    }
}