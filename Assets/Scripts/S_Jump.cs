using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_Jump : MonoBehaviour
{
    private Vector3 jump;
    public float jumpForce;
    public AudioSource audioJump;

    private bool isGrounded;

    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        jump = new Vector3(0.0f, 1.0f, 0.0f);
        isGrounded = true;
    }

    void FixedUpdate()
    {
        if (transform.position.y <= 1.2)
        {
            isGrounded = true;
        }

        if (Input.GetKey(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(jump * jumpForce, ForceMode.Impulse);
            audioJump.Play();
            isGrounded = false;
        }
    }
}
