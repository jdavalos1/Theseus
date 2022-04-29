using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class FieldItems : MonoBehaviour
{
   [SerializeField]
    protected Transform player;
    [SerializeField]
    private TextMeshProUGUI interactUI;
    [SerializeField]
    private Transform item;

    protected void ShowAndInteract(Action interact)
    {
        if (Vector3.Distance(player.position, item.position) <= InteractableConstants.MinDistanctShowAndInteract)
        {
            interactUI.enabled = true;
            if (Input.GetKeyDown(KeyCode.E)) interact();
        }
        else interactUI.enabled = false;
    }
}
