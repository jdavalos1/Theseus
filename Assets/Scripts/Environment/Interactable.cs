using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// Represents an item that can only be interacted and not picked.
/// </summary>
public class Interactable : FieldItems 
{
    // Update is called once per frame
    void Update()
    {
        ShowAndInteract(HandleInteractionItem);
    }

    private void HandleInteractionItem()
    {
        // TODO
        // If the player interacts have the dialog manager handle
        // what happens to the item. Each interactable needs to know
        // what file to display and should display in a single concise way.
        // The dialog manager can handle how dialog is done
        // Have to make sure the player can't move otherwise they'll move
        // while dialog is being displayed.

        throw new System.NotImplementedException();
    }
}
