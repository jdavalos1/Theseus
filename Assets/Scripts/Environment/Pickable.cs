using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickable : FieldItems 
{
    // Update is called once per frame
    void Update()
    {
        ShowAndInteract(Interact);
    }

    private void Interact()
    {
        Debug.Log("I have been picked");
        player.GetComponent<Player>().AddItems(new Useable());
    }
}
