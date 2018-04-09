using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovementManager : AbstractMovementManager
{
    Rigidbody2D rb2d;

    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        enabled = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Movement();
    }

    protected override void Movement()
    {
        if (Input.GetKey("w"))
        {
            rb2d.AddForce(transform.up * strength);
        }
        if (Input.GetKey("a"))
        {
            rb2d.AddForce(-transform.right * strength);
        }
        if (Input.GetKey("s"))
        {
            rb2d.AddForce(-transform.up * strength);
        }
        if (Input.GetKey("d"))
        {
            rb2d.AddForce(transform.right * strength);
        }
    }
}
