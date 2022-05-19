using UnityEngine;
using UnityEngine.InputSystem;

public class TestAnimScript : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 3f;
    public InputAction PlayerMov;

    Animator anim;

    Vector2 moveDirection = Vector2.zero;

    private void OnEnable()
    {

        PlayerMov.Enable();
    }
    private void OnDisable()
    {
        PlayerMov.Disable();

    }

    //Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnMovement(InputValue value)
    {
        if (moveDirection.x != 0  ll movement.y != 0) {
            anim.SetFloat("x", moveDirection.x);
            anim.SetFloat("y", moveDirection.y);

        }
    }
    // Update is called once per frame
    void Update()
    {
        // var z = Input.GetAxis("Vertical") * speed;
        //var x = Input.GetAxis("Horizontal") * speed;

        moveDirection = PlayerMov.ReadValue<Vector2>();


       // transform.Translate(x, 0, z);
     //  transform.Rotate(0, 0, 0);

        if (Input.GetKey(KeyCode.W))
        {
            anim.SetBool("IsWalking", true);
            anim.SetBool("IsIdle", false);

        }
        else if (Input.GetKey(KeyCode.S))
        {
            anim.SetBool("IsWalking", true);
            anim.SetBool("IsIdle", false);

        }
        else if (Input.GetKey(KeyCode.A))
        {
            anim.SetBool("IsWalking", true);
            anim.SetBool("IsIdle", false);

        }
        else if (Input.GetKey(KeyCode.D))
        {
            anim.SetBool("IsWalking", true);
            anim.SetBool("IsIdle", false);
        }
        else
        {
            anim.SetBool("IsWalking", false);
            anim.SetBool("IsIdle", true);
        }
    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(moveDirection.x * speed, moveDirection.y * speed);
    }
}