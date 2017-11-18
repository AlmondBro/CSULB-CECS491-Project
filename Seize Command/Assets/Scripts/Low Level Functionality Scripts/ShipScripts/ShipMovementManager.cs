using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovementManager : AbstractMovementManager {

    [SerializeField] float rotation_speed;
    [SerializeField] Rigidbody2D rb2d;

    // Update is called once per frame
    void Update () {
        Movement();
	}

    protected override void Movement()
    { 

        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        difference.Normalize();
        float rotation_z = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        Quaternion rot = Quaternion.Euler(0f, 0f, rotation_z + -90);


        transform.rotation = Quaternion.RotateTowards(transform.rotation, rot, rotation_speed * Time.deltaTime);

        if (Input.GetKey("w"))
        {
            rb2d.AddForce(transform.up * 10);
        }
        if (Input.GetKey("a"))
        {
            rb2d.AddForce(-transform.right * 10);
        }
        if (Input.GetKey("s"))
        {
            rb2d.AddForce(-transform.up * 10);
        }
        if (Input.GetKey("d"))
        {
            rb2d.AddForce(transform.right * 10);
        }

        if (Input.GetKeyDown("space"))
        {
            rb2d.velocity = new Vector2(0, 0);
        }
    }
}
