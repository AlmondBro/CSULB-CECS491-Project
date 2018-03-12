//@Author: Maria Nuila
using System.Collections; 
using System.Collections.Generic; 
using UnityEngine;  

public class AIInteractor: MonoBehaviour {
	
	protected List<GameObject> listOfHumanPlayers; //list of all the players on the screen

	void Start()
	{
		listOfHumanPlayers = new List<GameObject> ();
	}


	void OnTriggerEnter2D(Collider2D  collision)
	{
		Debug.Log ("entered trigger");
		if (collision.gameObject.CompareTag("Player"))
		{
			listOfHumanPlayers.Add(collision.gameObject);

			MonoBehaviour.print ("I am adding this object to my list");

		}

	}
}

