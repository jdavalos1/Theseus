using System.Collections.Generic;
using UnityEngine;

public class DialogBuilder
{
    private readonly Dialog dialog;

    public Dialog Dialog { get { return dialog; } }

    public DialogBuilder(string fileLocation)
    {
        // Load the json and create the object
        TextAsset dialogJson = Resources.Load<TextAsset>(fileLocation);
        dialog = JsonUtility.FromJson<Dialog>(dialogJson.text);
    }

    public DialogBuilder(string title, string description)
    {
        dialog = new Dialog();
        dialog.Title = title;
        dialog.Description = description;
    }
}
