using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class networkPlayerMovementManager : AbstractMovementManager {

	public Vector2 MovementDirection { get; set; }	

	Rigidbody2D rb2dPlayer;

	void Start()
	{
		rb2dPlayer = GetComponent<Rigidbody2D>();
	}

	void Update()
	{
		if (!isLocalPlayer) 
		{
			return;
		}

		Movement();
	}

	protected override void Movement()
	{
		int x = 0;
		int y = 0;

		if (Input.GetKey(KeyCode.W))
		{
			//Debug.Log ("forward");
			y = 1;
		}
		if (Input.GetKey(KeyCode.A))
		{
			x = -1;
		}
		if (Input.GetKey(KeyCode.S))
		{
			y = -1;
		}
		if (Input.GetKey(KeyCode.D))
		{
			x = 1;
		}

		if(y != 0 && x != 0)
		{
			float diag_speed = strength * Mathf.Sqrt(.5f);
			MovementDirection = new Vector2(diag_speed * x, diag_speed * y);
		}
		else
		{
			//Debug.Log ("pressed a button");
			MovementDirection = new Vector2(strength * x, strength * y);
		}

		if (transform.root.CompareTag ("Ship"))
		{
			Rigidbody2D rb2dShip = GetComponentInParent<Rigidbody2D> ();
			rb2dPlayer.velocity = MovementDirection + rb2dShip.velocity;
		} 
		else
		{
			rb2dPlayer.velocity = MovementDirection;
			//Debug.Log (rb2dPlayer.velocity);
		}
	}
}
