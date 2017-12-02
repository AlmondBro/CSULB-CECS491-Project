using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipInteractor : AbstractInteractionManager {

	AbstractInteractionManager boardingManager;
	// Use this for initialization
	void Awake()
	{
		enabled = false;
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown(KeyCode.F))
		{

			if (interactable != null) 
			{
				interactable.Interact (gameObject);
			} 

		}
		
	}
}
