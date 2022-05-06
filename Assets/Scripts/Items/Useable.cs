using System;

[Serializable]
public abstract class Useable
{
    public string Title;
    public string Description;

    public abstract void UseItem(Player p);
}
