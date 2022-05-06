using System;

[Serializable]
public class Potion : Useable
{
    public int HealthIncrease;

    public override void UseItem(Player p)
    {
        p.health += HealthIncrease;
        throw new NotImplementedException();
    }
}
