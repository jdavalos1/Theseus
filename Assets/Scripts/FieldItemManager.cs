using System.Collections;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;

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
        if(SharedInstance == null) SharedInstance = this;
        // Prepare the viewable items on the screen
        _useables = new Dictionary<FieldItemType, Useable>();
        TextAsset textAsset = Resources.Load<TextAsset>("Pickables JSON/Potion");
        Potion potion = JsonUtility.FromJson<Potion>(textAsset.text);
        _useables.Add(FieldItemType.HealthPotion, potion);
    }

    /// <summary>
    /// The type of item used on the field
    /// </summary>
    public enum FieldItemType
    {
        HealthPotion,
    }
}
