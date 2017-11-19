using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovementManager : AbstractMovementManager
{
    Rigidbody2D rb2d;
    [SerializeField] Rigidbody2D rb2dShip;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        //Debug.Log(rb2dShip);
    }

    void FixedUpdate()
    {
        Movement();
    }

    protected override void Movement()
    {
        int x = 0;
        int y = 0;

        if (Input.GetKey(KeyCode.W))
        {
            y = 1;
        }
        if (Input.GetKey(KeyCode.A))
        {
            x = -1;
        }
        if (Input.GetKey(KeyCode.S))
        {
            y = -1;
        }
        if (Input.GetKey(KeyCode.D))
        {
            x = 1;
        }

        if(y != 0 && x != 0)
        {
            float diag_speed = strength * Mathf.Sqrt(.5f);
            rb2d.velocity = new Vector2(diag_speed * x, diag_speed * y);
        }
        else
        {
            rb2d.velocity = new Vector2(strength * x, strength * y);
        }

        rb2d.velocity += rb2dShip.velocity;

        Debug.Log(rb2d.velocity);
    }
}