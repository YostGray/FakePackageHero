public class PlainRing : ItemBase, IInBagAddBuffItem
{
    public PlainRing(ItemCfgData itemCfg) : base(itemCfg)
    {

    }

    public Buff GetEffectBuff()
    {
        return new ItemAddMaxHPBuff(5);
    }
}
