using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PilotChair : MonoBehaviour {

    public GameObject chair;
    public GameObject seated;
    public GameObject ship;

    void OnTriggerStay2D(Collider2D other)
    {
        SpriteRenderer visual = other.GetComponent<SpriteRenderer>();
        CharacterControl script = other.GetComponent<CharacterControl>();
        ShipPilot pilot = ship.GetComponent<ShipPilot>();

        if (other.tag == "Player" && Input.GetKeyDown("e"))
        {
            Debug.Log("Gunner");
            chair.SetActive(false);
            seated.SetActive(true);
            visual.enabled = false;
            script.enabled = false;
            pilot.enabled = true;

        }

        if (visual.enabled == false && Input.GetKeyDown("f"))
        {
            Debug.Log("F");
            chair.SetActive(true);
            seated.SetActive(false);
            visual.enabled = true;
            script.enabled = true;
            pilot.enabled = false;
        }

    }

}
