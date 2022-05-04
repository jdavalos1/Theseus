using System;
/// <summary>
/// Holder class for dialog of items/ NPCs
/// </summary>
[Serializable]
public class Dialog 
{
    /// <summary>
    /// Title of an item. Can be blank if the text is from
    /// an NPC.
    /// </summary>
    public string Title;
    /// <summary>
    /// Description/ speech of the item/ NPC.
    /// </summary>
    public string Description;
}
