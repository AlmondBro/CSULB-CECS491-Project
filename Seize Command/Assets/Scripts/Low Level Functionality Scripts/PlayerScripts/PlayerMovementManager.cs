using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementManager : AbstractMovementManager
{
    public Vector2 MovementDirection
    {
        get
        {
            return movementDirection;
        }
    }

    Vector2 movementDirection;

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
            movementDirection = new Vector2(diag_speed * x, diag_speed * y);
        }
        else
        {
            movementDirection = new Vector2(strength * x, strength * y);
        }
    }
}