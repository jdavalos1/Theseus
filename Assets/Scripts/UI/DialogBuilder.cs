using System.Collections.Generic;
using UnityEngine;

public class DialogBuilder
{
    private Queue<string> chunks;
    private readonly string title;
    private readonly string speaker;

    /// <summary>
    /// Next chunk in the dialog
    /// </summary>
    public string NextChunk
    {
        get
        {
            string nextChunk = chunks.Dequeue();
            chunks.Enqueue(nextChunk);

            return nextChunk;
        }
    }

    /// <summary>
    /// Previous chunk in the dialog
    /// </summary>
    public string PreviousChunk
    {
        get
        {
            throw new System.NotImplementedException();
        }
    }

    public DialogBuilder(string fileLocation, int height)
    {
        // Load the json and create the object
        TextAsset dialogJson = Resources.Load<TextAsset>(fileLocation);
        Dialog dialog = JsonUtility.FromJson<Dialog>(dialogJson.text);

        speaker = dialog.Speaker;
        title = dialog.Title;

        chunks = new Queue<string>();
        chunks.Enqueue(dialog.Description);
        chunks.Enqueue(null);
        // TODO: 
        // Build the block based on the size of the text height
        // Last chunk should be null in case the user wants to go
        // back and forth
    }

    public string GetTitle() { return title; }
    public string GetSpeaker() { return speaker; }
}
