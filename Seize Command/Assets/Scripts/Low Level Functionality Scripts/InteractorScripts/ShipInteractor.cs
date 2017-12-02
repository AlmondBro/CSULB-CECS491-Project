using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipInteractor : AbstractInteractionManager
{
	void Awake()
	{
		enabled = false;
	}
	
	void FixedUpdate ()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (interactable != null)
            {
                interactable.Interact(gameObject);
            }
        }
	}
}
