using System.Collections.Generic;
using UnityEngine;

public class DialogBuilder
{
    private readonly Dialog dialog;

    public DialogBuilder(string fileLocation)
    {
        // Load the json and create the object
        TextAsset dialogJson = Resources.Load<TextAsset>(fileLocation);
        dialog = JsonUtility.FromJson<Dialog>(dialogJson.text);

    }

    public string GetTitle() { return dialog.Title; }
    public string GetDescription() { return dialog.Description; }
}