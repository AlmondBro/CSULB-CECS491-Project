using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AbstractMovementManager))]
public class PositionOffsetWhileSeated : MonoBehaviour
{
    Rigidbody2D rb2dPlayer;
    //Rigidbody2D rb2dShip;
    
	void Start ()
    {
        Rigidbody2D[] rb2dArray = GetComponentsInParent<Rigidbody2D>();
        rb2dPlayer = rb2dArray[0];

        //rb2dShip = rb2dArray[1];
	}
	
	void FixedUpdate ()
    {
        OffSetPlayerPosition();
	}

    void OffSetPlayerPosition()
    {
        Vector2 playerVelocity = GetComponent<PlayerMovementManager>().MovementDirection;
        rb2dPlayer.velocity = playerVelocity; //+ rb2dShip.velocity;
    }
}
