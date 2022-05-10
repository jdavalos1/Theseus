using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory
{
    private List<Consumable> currentlyActive;
    private Dictionary<Consumable, int> itemsOnHand;

    public Inventory()
    {
        currentlyActive = new List<Consumable>();
        itemsOnHand = new Dictionary<Consumable, int>();
    }

    public List<Consumable> CurrentlyActive
    {
        get { return currentlyActive; }
    }

    /// <summary>
    /// Active being used on the player
    /// </summary>
    /// <param name="p"></param>
    /// <param name="u"></param>
    public void UpdateActiveList(Consumable u)
    {
        // TODO:
        // Figure out how the active items will be used on the player
        // Do it in the individual items active
        // They should only be able to use it based on the number on hand
        itemsOnHand[u]--;
        if (itemsOnHand[u] <= 0)
        {
            itemsOnHand.Remove(u);
            currentlyActive.Remove(u);
        }
    }

    /// <summary>
    /// Add item to the inventory list
    /// </summary>
    /// <param name="useable">Item to add</param>
    /// <param name="numbOf">Number of the item to add</param>
    public void AddItemToInventory(Consumable useable, int numbOf)
    {
        if (!itemsOnHand.ContainsKey(useable)) itemsOnHand.Add(useable, numbOf);
        else itemsOnHand[useable]++;
        currentlyActive.Add(useable);
    }

    public void ChangeActiveList(int oldActive, Consumable useable)
    {
    }
}
