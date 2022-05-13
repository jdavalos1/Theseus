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

    private Dictionary<FieldItemType, Consumable> _consumables;
    public Dictionary<FieldItemType, Consumable> ConsumableList { get { return _consumables; } }

    // Start is called before the first frame update
    void Start()
    {
        if (SharedInstance != null) return;

        SharedInstance = this;
        _consumables = new Dictionary<FieldItemType, Consumable>();
        TextAsset textAsset;
        dynamic consumable;


        // Oh boy you're gunna love this:
        // convert enum to a type of class and create the object based on
        // json file
        foreach (FieldItemType fit in Enum.GetValues(typeof(FieldItemType)))
        {
            textAsset = Resources.Load<TextAsset>(InteractableConstants.PickablesBaseFolder + fit.ToString());
            consumable = JsonUtility.FromJson(textAsset.text, Type.GetType(fit.ToString()));
            _consumables.Add(fit, (consumable as Consumable));
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
