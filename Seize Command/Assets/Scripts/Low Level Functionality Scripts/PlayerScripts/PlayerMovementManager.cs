﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementManager : AbstractMovementManager
{
    Rigidbody2D rb2d;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        Movement();
    }

    protected override void Movement()
    {
        int x = 0;
        int y = 0;

        if (Input.GetKey("w"))
        {
            y = 1;
        }
        if (Input.GetKey("a"))
        {
            x = -1;
        }
        if (Input.GetKey("s"))
        {
            y = -1;
        }
        if (Input.GetKey("d"))
        {
            x = 1;
        }

        rb2d.velocity = new Vector2(speed * x, speed * y);
    }
}