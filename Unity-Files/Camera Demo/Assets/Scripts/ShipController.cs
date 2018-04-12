using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour {

    Rigidbody2D rb2d;
    public float offset;
    public GameObject cannon;
    public Transform cannonSpawn;
    public GameObject outside;
    public GameObject inside;

    void Start()
    {
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
            rb2d.AddForce(-transform.right * 5);
        }
        if (Input.GetKey("s"))
        {
            rb2d.AddForce(-transform.up * 5);
        }
        if (Input.GetKey("d"))
        {
            rb2d.AddForce(transform.right * 5);
        }

        if (Input.GetKey("space"))
        {
            rb2d.drag = 5;
        }
        if (Input.GetKeyUp("space"))
        {
            rb2d.drag = 0;
        }

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(cannon, cannonSpawn.position, cannonSpawn.rotation);
        }
        /*
        if(Camera.main.orthographicSize <= 3)
        {
            outside.SetActive(false);
            inside.SetActive(true);
        }
        else
        {
            outside.SetActive(true);
            inside.SetActive(false);
        }
        */
    }
}
