using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMover : MonoBehaviour
{
    Vector2 direction;
    public Rigidbody2D rb;
    public float force;
    public float jumpHeight = 10f;
    public float dashDist = 12f;
    private bool grounded;
    public float dashes = 1;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        direction.x = Input.GetAxis("Horizontal");
        direction.y = Input.GetAxis("Vertical");

        if (Input.GetKeyDown(KeyCode.Space) && grounded)
        {
            Jump();
        }

        if (Input.GetKeyDown(KeyCode.Q) && dashes >= 1)
        {
            Dash();
        }
        
    }
    void Jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, jumpHeight);
    }

    void Dash()
    {
        Vector2 directionToDash = new Vector2(direction.x, direction.y);

        rb.velocity = new Vector2(directionToDash.x * dashDist, directionToDash.y * dashDist);
        dashes -= 1;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            grounded = true;
            dashes = 1;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            grounded = false;
        }
    }
    private void FixedUpdate()
    {
      rb.AddForce(Vector2.right * direction.x * force * Time.deltaTime);
    }

}
