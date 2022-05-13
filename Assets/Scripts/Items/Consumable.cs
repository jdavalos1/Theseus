using System;

[Serializable]
public abstract class Consumable
{
    public string Title;
    public string Description;

    public abstract void UseItem(Player p);
}
