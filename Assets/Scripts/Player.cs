using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField]
    private float speed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
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

        transform.position += move * Time.deltaTime * speed;
    }
}
