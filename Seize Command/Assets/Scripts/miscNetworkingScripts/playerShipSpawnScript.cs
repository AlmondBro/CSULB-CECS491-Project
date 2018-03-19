using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class playerShipSpawnScript : NetworkBehaviour {
	public GameObject shipPrefab;

	// Use this for initialization
	void Start () {
		
	}

	public override void OnStartServer()
	{
		var spawnPosition = new Vector3(0.0f,0.0f,0.0f);
		var spawnRotation = Quaternion.Euler(0.0f,0.0f,0.0f);

		var ship = (GameObject) Instantiate(shipPrefab,spawnPosition,spawnRotation);
		NetworkServer.Spawn(ship);
		
		Utility.startingShip = ship;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

}
