using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestAnimScript : MonoBehaviour
{

    public float speed;
 
    Animator anim;

    //Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        var z = Input.GetAxis("Vertical") * speed;
        var x = Input.GetAxis("Horizontal") * speed;

        transform.Translate(x, 0, z);
        transform.Rotate(0, 0, 0);

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

    }
