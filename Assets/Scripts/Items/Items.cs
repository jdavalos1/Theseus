using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Items : MonoBehaviour
{
    [SerializeField]
    private Transform player;
    [SerializeField]
    private TextMeshProUGUI interactUI;
    [SerializeField]
    private Transform item;
    protected void ShowAndInteract()
    {
        if (Vector3.Distance(player.position, item.position) <= InteractableConstants.MinDistanctShowAndInteract)
        {
            interactUI.enabled = true;
            if (Input.GetKeyDown(KeyCode.E)) Debug.Log("interacting");
        }
        else interactUI.enabled = false;
    }
}