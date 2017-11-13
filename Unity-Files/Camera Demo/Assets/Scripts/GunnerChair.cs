using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunnerChair : MonoBehaviour {

    public GameObject chair;
    public GameObject seated;
    public GameObject ship;

    void OnTriggerStay2D(Collider2D other)
    {
        SpriteRenderer visual = other.GetComponent<SpriteRenderer>();
        CharacterControl script = other.GetComponent<CharacterControl>();
        ShipShoot shoot = ship.GetComponent<ShipShoot>();

        if (other.tag == "Player" && Input.GetKeyDown("e"))
        {
            Debug.Log("Gunner");
            chair.SetActive(false);
            seated.SetActive(true);
            visual.enabled = false;
            script.enabled = false;
            shoot.enabled = true;
            
        }

        

    }
}
