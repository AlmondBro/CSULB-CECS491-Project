using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipShoot : MonoBehaviour {

    public GameObject cannon;
    public Transform cannonSpawn;
    public GameObject player;
    public GameObject chair;
    public GameObject seated;
	
	void FixedUpdate () {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(cannon, cannonSpawn.position, cannonSpawn.rotation);
        }

        SpriteRenderer visual = player.GetComponent<SpriteRenderer>();
        CharacterControl script = player.GetComponent<CharacterControl>();
        ShipShoot self = gameObject.GetComponent<ShipShoot>();

        if (visual.enabled == false && Input.GetKeyDown("f"))
        {
            Debug.Log("F");
            chair.SetActive(true);
            seated.SetActive(false);
            visual.enabled = true;
            script.enabled = true;
            self.enabled = false;

        }


    }
}
