using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JournalItem 
{
    private readonly string _title;
    private readonly string _description;

    public string Title { get { return _title; } }
    public string Description { get { return _description; } }
    // TODO: Figure out how to pass image into the journal entry
    //private readonly Sprite image;

    public JournalItem(string title, string description)
    {
        _title = title;
       _description = description;
    }
}
