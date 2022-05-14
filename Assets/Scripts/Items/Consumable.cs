using System;
using UnityEngine;

[Serializable]
public abstract class Consumable
{
    public string Title;
    public string Description;
    [NonSerialized]
    public Sprite sprite;

    public abstract void UseItem(Player p);
}
