using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPositionOffsetInSeat : MonoBehaviour {

    Rigidbody2D rb2d;
    Rigidbody2D rb2dShip;
    
	void Start ()
    {
        rb2d = GetComponentInChildren<Rigidbody2D>();
        rb2dShip = GetComponentInParent<Rigidbody2D>();
	}
	
	void FixedUpdate ()
    {
        OffSetPlayerPosition();
	}

    void OffSetPlayerPosition()
    {
        rb2d.velocity = rb2dShip.velocity;
    }
}
