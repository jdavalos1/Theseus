using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private Transform player;
    [SerializeField]
    private float speed;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        HandleMovement();
    }

    void HandleMovement()
    {
        float horizontal = Input.GetAxis(PlayerConstants.HorizontalAxis);
        float vertical = Input.GetAxis(PlayerConstants.VerticalAxis);

        Vector3 move = new Vector3(horizontal, 0, vertical);

        player.transform.position += speed * Time.deltaTime * move;
    }
}
