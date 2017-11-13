using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeamScript : MonoBehaviour {

    public Transform ship;

    private void Update()
    {

        transform.position = ship.position + (transform.up * 3);

        if (Input.GetKeyUp("3"))
        {
            gameObject.SetActive(false);
        }
    }

}
