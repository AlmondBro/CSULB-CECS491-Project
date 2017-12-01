using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipInteractable : MonoBehaviour,IInteractable {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Interact(GameObject ship) //the ship that interacts with this ship
	{
		// 'gameObject' the ship that holds this script
		gameObject.transform.rotation =  new Quaternion(0,0,0,0);
		gameObject.GetComponent<ConstantForce2D> ().enabled = false;
		gameObject.GetComponent<Rigidbody2D> ().velocity = new Vector2(0,0);

		ship.transform.rotation =  new Quaternion(0,0,0,0);
		ship.GetComponent<Rigidbody2D> ().velocity = new Vector2(0,0);
		Debug.Log ("Boarding initiated!");

		//lock ships in place
		ship.transform.position = gameObject.transform.position - new Vector3 (10, 0, 0);
	}
}
