using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControl : MonoBehaviour {

    Rigidbody2D rb2d;
    public float offset;

    void Start () {
        rb2d = GetComponent<Rigidbody2D>();
    }
	
	void FixedUpdate () {

        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        difference.Normalize();
        float rotation_z = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotation_z + offset);

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
