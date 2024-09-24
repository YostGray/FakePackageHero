public class HeroCharacter : Character
{
    public HeroCharacter(HeroCfgData heroCfg)
    {
        HP = new CharacterAttribute(heroCfg.default_HP);
        MP = new CharacterAttribute(heroCfg.default_MP);
        AP = new CharacterAttribute(heroCfg.default_AP);

        resName = "Hero/player";
        sizeInScene = 18;
    }

    public override void OnTurnStart()
    {
        // 恢复AP
        AP.curValue = maxAp;
    }
}
