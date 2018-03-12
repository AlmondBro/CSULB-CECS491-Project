//@Author: Maria Nuila
using System.Collections; 
using System.Collections.Generic; 
using UnityEngine;  
public class AIAttack :AbstractAttackManager  {    
	
	protected List<GameObject> listOfHumanPlayers; //list of all the players on the screen

	int playerIterator;
	GameObject selectedPlayer; //the player the AI attacks
 	public float attackTime = 2; //time in seconds between each attack     
	float curTime = 0; //time in seconds since last attack 
	float damping = 60; //rate the rotation occurs before the shots are fired
	float maxDistance;

	void Start(){         
		        
		Weapon = GetComponentInChildren<IFireable>(); 
		playerIterator = 0; 
		listOfHumanPlayers = new List<GameObject> ();

	}    

	void OnTriggerEnter2D(Collider2D  collision)
	{

		if (collision.gameObject.CompareTag("Player"))
		{
			listOfHumanPlayers.Add(collision.gameObject);



		}

	}
 
	

	void Update(){         



		//If the array of game objects in not empty
		if (listOfHumanPlayers.Count != 0) {
			
			if (listOfHumanPlayers [playerIterator] == null) {
				listOfHumanPlayers.Remove (listOfHumanPlayers [playerIterator]);
				MonoBehaviour.print ("I am removing this object from my list");
			}
			if (listOfHumanPlayers.Count != 0) {
				selectedPlayer = listOfHumanPlayers [playerIterator];
				//Distance between player and ai         
				Vector3 playerDistance = selectedPlayer.transform.position - transform.position;         
				//have ai face the human player before proceeding with the attack         
				float angle = (Mathf.Atan2 (playerDistance.y, playerDistance.x) * Mathf.Rad2Deg) - 90;         
				Quaternion rotation = Quaternion.AngleAxis (angle, Vector3.forward);         
				transform.rotation = Quaternion.RotateTowards (transform.rotation, rotation, Time.deltaTime * damping);    

				//update current time accordingly         
				curTime += Time.deltaTime;           
				//check to see if we can attack now         
				if (curTime >= attackTime) {                      
					Attack ();              
					curTime = 0; //reset again          
				}     
			}
		}

	}
}