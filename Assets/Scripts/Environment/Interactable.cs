using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


/// <summary>
/// Represents an item that can only be interacted and not picked.
/// </summary>
public class Interactable : FieldItems 
{
    [SerializeField]
    private string ItemResourceLocation;

    // Update is called once per frame
    void Update()
    {
        ShowAndInteract(HandleInteractionItem);
    }

    private void HandleInteractionItem()
    {
        // TODO
        // Call the ui manager's show dialog functionality
        // Have to make sure the player can't move otherwise they'll move
        // while dialog is being displayed.

        DialogBuilder db = new DialogBuilder("Interactables JSON/AchillesVase", 0);
        UIManager.SharedInstance.ShowDialog(db);
    }
}
