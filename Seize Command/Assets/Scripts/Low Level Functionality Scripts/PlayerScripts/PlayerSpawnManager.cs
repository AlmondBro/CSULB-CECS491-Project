using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PlayerSpawnManager : NetworkBehaviour {
    
	void Start()
	{
		if (!isLocalPlayer) {
			return;
		}

		
        GameObject[] startingShips = GameObject.FindGameObjectsWithTag("startingShip");
        gameObject.transform.parent = startingShips[0].transform;
		

		this.setPlayer ();

		
	}

	
	// Update is called once per frame
	void Update () {
		
	}

	 void setPlayer()
	{
		Camera.main.GetComponent<CameraController> ().lockToPlayer (gameObject);
	}

}
