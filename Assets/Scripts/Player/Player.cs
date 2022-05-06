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
    private Dictionary<Useable, int> useableItems;
    // Start is called before the first frame update
    void Start()
    {
        useableItems = new Dictionary<Useable, int>();
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

    public void HandleItemUse(KeyCode key)
    {

    }

    /// <summary>
    /// Add the item whenever the item is pressed
    /// </summary>
    /// <param name="useable"></param>
    public void AddItems(Useable useable)
    {
        inventory.AddItemToInventory(useable, 1);
    }
}
