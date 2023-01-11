using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rb;

    [SerializeField] private float movementSpeed = 6f;
    [SerializeField] private float jumpSpeed = 10f;

    [SerializeField] Transform groundCheck;
    [SerializeField] LayerMask ground;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal") * movementSpeed;
        float verticalInput = Input.GetAxis("Vertical") * movementSpeed;

        rb.velocity = new Vector3(horizontalInput, rb.velocity.y, verticalInput);

        if (Input.GetButtonDown("Jump") && isGrounded())
        {
            rb.velocity = new Vector3(rb.velocity.x, jumpSpeed, rb.velocity.z);
        }
        
    }

    bool isGrounded()
    {
        return Physics.CheckSphere(groundCheck.position, .1f, ground);
        //return true;
    }
}
