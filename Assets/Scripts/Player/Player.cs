using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool CanMove;

    [SerializeField]
    private Transform player;
    [SerializeField]
    private float moveSpeed;

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
            if (Input.GetKeyDown(KeyCode.Escape))
            {
            }
            HandleMovement();
        }
    }

    void HandleMovement()
    {
        float horizontal = Input.GetAxis(PlayerConstants.HorizontalAxis);
        float vertical = Input.GetAxis(PlayerConstants.VerticalAxis);

        Vector3 move = new Vector3(horizontal, 0, vertical);

        player.transform.position += moveSpeed * Time.deltaTime * move;
    }


    /// <summary>
    /// Handle the use of an active item in the combat menu
    /// </summary>
    /// <param name="u">The useable item to activate</param>
    public void HandleItemUse(Consumable u)
    {
        u.UseItem(this);
        inventory.UpdateActiveList(u);
    }

    /// <summary>
    /// Add the item whenever the item is pressed
    /// </summary>
    /// <param name="useable"></param>
    public void AddItems(Consumable useable)
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

    /// <summary>
    /// Used to speed character by speed
    /// </summary>
    /// <param name="speed"></param>
    public void BoostCharacter(int speed)
    {
        StartCoroutine(SpeedBoost(speed));
    }

    private IEnumerator SpeedBoost(int speed)
    {
        float originalSpeed = moveSpeed;
        moveSpeed = speed;
        float timer = 0f;
        
        while(timer < PlayerConstants.PlayerSpeedDecayTime)
        {
            timer += Time.deltaTime;
            moveSpeed = Mathf.Lerp(speed, originalSpeed, timer / PlayerConstants.PlayerSpeedDecayTime);
            yield return null;
        }

        moveSpeed = originalSpeed;
    }
}
