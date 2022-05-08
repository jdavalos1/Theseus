using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool CanMove;

    [SerializeField]
    private Transform player;
    [SerializeField]
    private float speed;

    public float health;

    private Inventory inventory;
    private Journal journal;
    // Start is called before the first frame update
    void Start()
    {
        inventory = new Inventory();
        journal = new Journal();
        CanMove = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (CanMove)
        {
            HandleMovement();
        }
    }

    void HandleMovement()
    {
        float horizontal = Input.GetAxis(PlayerConstants.HorizontalAxis);
        float vertical = Input.GetAxis(PlayerConstants.VerticalAxis);

        Vector3 move = new Vector3(horizontal, 0, vertical);

        player.transform.position += speed * Time.deltaTime * move;
    }


    /// <summary>
    /// Handle the use of an active item in the combat menu
    /// </summary>
    /// <param name="u">The useable item to activate</param>
    public void HandleItemUse(Useable u)
    {
        u.UseItem(this);
        inventory.UpdateActiveList(u);
    }

    /// <summary>
    /// Add the item whenever the item is pressed
    /// </summary>
    /// <param name="useable"></param>
    public void AddItems(Useable useable)
    {
        inventory.AddItemToInventory(useable, 1);
    }

    /// <summary>
    /// Add the journal entry to the journal
    /// </summary>
    /// <param name="d">Dialog that houses all info</param>
    public void AddJournalEntry(Dialog d)
    {
        journal.AddJournalEntry(d);
    }
}
