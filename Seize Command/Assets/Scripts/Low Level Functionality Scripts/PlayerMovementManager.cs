using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementManager : MonoBehaviour
{
    Rigidbody2D rb2d;

    public float speed, offset;
    // Use this for initialization
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Character_Move();
    }

    void Character_Move()
    {

        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        difference.Normalize();
        float rotation_z = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotation_z + offset);


        int x = 0;
        int y = 0;
        if (Input.GetKey("w"))
        {
            y = 1;
        }
        if (Input.GetKey("a"))
        {
            x = -1;
            //rb2d.AddForce(-transform.right * 10);
        }
        if (Input.GetKey("s"))
        {
            y = -1;
            //rb2d.AddForce(-transform.up * 10);
        }
        if (Input.GetKey("d"))
        {
            x = 1;
            //rb2d.AddForce(transform.right * 10);
        }

        rb2d.velocity = new Vector2(speed * x, speed * y);

        if (Input.GetKeyDown("space"))
        {
            rb2d.velocity = new Vector2(0, 0);
        }


    }
}