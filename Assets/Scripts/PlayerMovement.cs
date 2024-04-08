using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField]
    private Rigidbody2D rigidBody;

    [SerializeField]
    private float speed = 10f;

    [SerializeField]
    private float jumpForce = 16f;

    [SerializeField]
    private Transform groundCheck;

    [SerializeField]
    private LayerMask groundLayer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rigidBody.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * speed, rigidBody.velocity.y);

        // Jumping
        if (Input.GetButtonDown("Jump") && isGrounded()){
            rigidBody.velocity = new Vector2(rigidBody.velocity.x, jumpForce);
        }

    }

    private bool isGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.09f, groundLayer);
    }
}
