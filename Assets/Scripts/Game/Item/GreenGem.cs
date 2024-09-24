public class GreenGem : ItemBase, IEffectNearByItem
{
    public GreenGem(ItemCfgData itemCfg) : base(itemCfg)
    {

    }

    public Buff GetEffectBuff()
    {
        return new ItemAddDmgBuff(1);
    }

    public ItemShape GetEffectShape()
    {
        return ItemShape.Near4shap;
    }
}
