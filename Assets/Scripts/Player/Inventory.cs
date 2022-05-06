using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory
{
    private List<Useable> currentlyActive;
    private Dictionary<Useable, int> itemsOnHand;

    public Inventory()
    {
        currentlyActive = new List<Useable>();
        itemsOnHand = new Dictionary<Useable, int>();
    }

    public List<Useable> CurrentlyActive
    {
        get { return currentlyActive; }
    }

    public void UseActive(Player p, int activePressed)
    {
        // TODO:
        // Figure out how the active items will be used on the player
        // Do it in the individual items active
        // They should only be able to use it based on the number on hand
    }

    /// <summary>
    /// Add item to the inventory list
    /// </summary>
    /// <param name="useable">Item to add</param>
    /// <param name="numbOf">Number of the item to add</param>
    public void AddItemToInventory(Useable useable, int numbOf)
    {
        if (!itemsOnHand.ContainsKey(useable)) itemsOnHand.Add(useable, numbOf);
        else itemsOnHand[useable]++;
        currentlyActive.Add(useable);
    }

    public void ChangeActiveList(int oldActive, Useable useable)
    {
    }
}
