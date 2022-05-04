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
    private string ItemName;

    // Update is called once per frame
    void Update()
    {
        ShowAndInteract(HandleInteractionItem);
    }

    /// <summary>
    /// Handle how interactions are done with the interactable item
    /// </summary>
    private void HandleInteractionItem()
    {
        DialogBuilder db = new DialogBuilder(InteractableConstants.InteractablesBaseFolder + ItemName);
        UIManager.SharedInstance.ShowDialog(db);
    }
}
