using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipPilot : MonoBehaviour {

    Rigidbody2D rb2d;
    public float offset;
    public GameObject player;
    public GameObject chair;
    public GameObject seated;
    public GameObject door;

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
            rb2d.velocity = transform.up * 2;
        }
        if (Input.GetKey("a"))
        {
            rb2d.velocity = -transform.right * 2;
        }
        if (Input.GetKey("s"))
        {
            rb2d.velocity = -transform.up * 2;
        }
        if (Input.GetKey("d"))
        {
            rb2d.velocity = transform.right * 2;
        }

        if (Input.GetKeyDown("space"))
        {
            rb2d.velocity = new Vector2(0,0);
        }

        SpriteRenderer visual = player.GetComponent<SpriteRenderer>();
        CharacterControl script = player.GetComponent<CharacterControl>();
        ShipPilot self = gameObject.GetComponent<ShipPilot>();

        if (visual.enabled == false && Input.GetKeyDown("f"))
        {
            Debug.Log("F");
            chair.SetActive(true);
            seated.SetActive(false);
            visual.enabled = true;
            script.enabled = true;
            self.enabled = false;
            door.SetActive(false);

        }

    }
}
