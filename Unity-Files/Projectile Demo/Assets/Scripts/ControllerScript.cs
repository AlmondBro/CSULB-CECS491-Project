using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerScript : MonoBehaviour {

    private Rigidbody2D rb2d;
    public float speed;
    public float offset;

    public GameObject cannon;
    public GameObject shotgun;
    public GameObject beam;
    public GameObject disruptor;
    public GameObject missile;
    public GameObject torpedo;

    public Transform cannonSpawn;
    public Transform shotgunSpawn1;
    public Transform shotgunSpawn2;
    public Transform shotgunSpawn3;
    public Transform shotgunSpawn4;
    public Transform shotgunSpawn5;
    public Transform disruptorSpawn;
    public Transform missileSpawn;
    public Transform torpedoSpawn;

    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        //beam.SetActive(false);
    }

    void FixedUpdate()
    {
        //face the cursor
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        difference.Normalize();
        float rotation_z = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotation_z + offset);

        //movement
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

        //brake
        if (Input.GetKey("space"))
        {
            rb2d.drag = 5;
        }
        if (Input.GetKeyUp("space"))
        {
            rb2d.drag = 0;
        }

        //fire weapons
        if(Input.GetKeyDown("1"))
        {
            Instantiate(cannon, cannonSpawn.position, cannonSpawn.rotation);
        }
        if (Input.GetKeyDown("2"))
        {
            Instantiate(shotgun, shotgunSpawn1.position, shotgunSpawn1.rotation);
            Instantiate(shotgun, shotgunSpawn2.position, shotgunSpawn2.rotation);
            Instantiate(shotgun, shotgunSpawn3.position, shotgunSpawn3.rotation);
            Instantiate(shotgun, shotgunSpawn4.position, shotgunSpawn4.rotation);
            Instantiate(shotgun, shotgunSpawn5.position, shotgunSpawn5.rotation);
        }
        if (Input.GetKeyDown("3"))
        {
            beam.SetActive(true);
        }
        if (Input.GetKeyDown("4"))
        {
            Instantiate(disruptor, disruptorSpawn.position, disruptorSpawn.rotation);
        }
        if (Input.GetKeyDown("5"))
        {
            Instantiate(missile, missileSpawn.position, missileSpawn.rotation);
        }
        if (Input.GetKeyDown("6"))
        {
            Instantiate(torpedo, torpedoSpawn.position, torpedoSpawn.rotation);
        }

    }
}
