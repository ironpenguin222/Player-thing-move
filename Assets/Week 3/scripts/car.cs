using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car : MonoBehaviour
{
    float acceleration;
    float steering;
    float speed;
    public float maxSpeed = 1000;
    public float forwardSpeed = 500;
    public float steeringSpeed = 100;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        acceleration = Input.GetAxis("Vertical");
        steering = Input.GetAxis("Horizontal");
    }
    private void FixedUpdate()
    {
        rb.AddTorque(steering * -steeringSpeed * Time.deltaTime);
        Vector2 force = transform.up * acceleration * forwardSpeed * Time.deltaTime;
        if (rb.velocity.magnitude < maxSpeed)
        {
            rb.AddForce(force);
        }
    }
}
