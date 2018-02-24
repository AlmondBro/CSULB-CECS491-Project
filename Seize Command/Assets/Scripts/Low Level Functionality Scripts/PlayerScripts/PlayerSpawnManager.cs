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
