using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Interactable : Items
{
    [SerializeField]
    private Transform player;
    [SerializeField]
    private TextMeshProUGUI interactUI;
    [SerializeField]
    private Transform item;

    private void Update()
    {
        ShowAndInteract();
    }

    private void ShowAndInteract()
    {
        if (Vector3.Distance(player.position, item.position) <= InteractableConstants.MinDistanctShowAndInteract)
        {
            interactUI.enabled = true;
            if (Input.GetKeyDown(KeyCode.E)) Debug.Log("interacting");
        }
        else interactUI.enabled = false;
    }

}
