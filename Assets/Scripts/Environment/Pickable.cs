using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Reprensets an item that's pickable by the player and will be updated
/// in their inventory when interacted.
/// </summary>
public class Pickable : FieldItems 
{
    /// <summary>
    /// Type of field item to add to the player's inventory
    /// </summary>
    [SerializeField]
    FieldItemManager.FieldItemType pickType;
    // Update is called once per frame
    void Update()
    {
        ShowAndInteract(Interact);
    }

    /// <summary>
    /// Interaction after the user touches the item.
    /// </summary>
    private void Interact()
    {
        Debug.Log(pickType);
        player.parent.GetComponent<Player>().AddItems(FieldItemManager.SharedInstance.UseableLists[pickType]);

        gameObject.SetActive(false);
    }
}
