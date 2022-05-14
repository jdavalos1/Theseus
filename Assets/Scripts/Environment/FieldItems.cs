using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEditor;
/// <summary>
/// Represents an item in game and handles what it does.
/// </summary>
public class FieldItems : MonoBehaviour
{
    [SerializeField]
    GameObject interactSprite;
    [SerializeField]
    protected Transform player;
    [SerializeField]
    private Transform item;

    /// <summary>
    /// Show the keypress interaction and interact based on if the 
    /// player pressed the proper key.
    /// </summary>
    /// <param name="interact"></param>
    protected void ShowAndInteract(Action interact)
    {
        if (Vector3.Distance(player.position, item.position) <= InteractableConstants.MinDistanctShowAndInteract && FindObjectOfType<Player>().CanMove)
        {
            interactSprite.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E)) interact();
        }
        else interactSprite.SetActive(false);
    }
}
