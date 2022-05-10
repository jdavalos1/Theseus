using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class Cloak : Consumable
{
    public int SpeedBoost;

    /// <summary>
    /// Boost character by x speed
    /// </summary>
    /// <param name="p">Player to speed</param>
    public override void UseItem(Player p)
    {
        p.BoostCharacter(SpeedBoost);
    }
}
