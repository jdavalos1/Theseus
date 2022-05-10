using System.Collections;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;
using System;

/// <summary>
/// Handles the different items on the field at run time
/// </summary>
public class FieldItemManager : MonoBehaviour
{
    public static FieldItemManager SharedInstance;

    private Dictionary<FieldItemType, Useable> _useables;
    public Dictionary<FieldItemType, Useable> UseableLists { get { return _useables; } }

    // Start is called before the first frame update
    void Start()
    {
        // TODO: change the dictionary to be string as key with name
        // manually add all field items to the manager
        // Create all scripts for the items
        if(SharedInstance == null) SharedInstance = this;
        // Prepare the viewable items on the screen
        _useables = new Dictionary<FieldItemType, Useable>();
        TextAsset textAsset = Resources.Load<TextAsset>("Pickables JSON/Cloak");
        Useable useable = JsonUtility.FromJson<Cloak>(textAsset.text);
        _useables.Add(FieldItemType.Cloak, useable);

        foreach(var fit in Enum.GetValues(typeof(FieldItemType)))
        {
            textAsset = Resources.Load<TextAsset>(InteractableConstants.PickablesBaseFolder + fit.ToString());
        }
    }

    /// <summary>
    /// The type of item used on the field
    /// </summary>
    public enum FieldItemType
    {
        Cloak,
        Pomegranate,
        Scroll,
        Shield,
        TheseusSword
    }
}
