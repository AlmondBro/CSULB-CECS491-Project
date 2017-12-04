using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipInteractor : AbstractInteractionManager
{
    public bool Interacting
    {
        get
        {
            return interacting;
        }
        set
        {
            interacting = value;
        }
    }

    public Transform BoardLocation
    {
        get
        {
            return boardLocation;
        }
        set
        {
            boardLocation = value;
        }
    }

    [SerializeField] Transform boardLocation;
    bool interacting;

    void Awake()
	{
		enabled = false;
        Interacting = false;
	}
	
	void FixedUpdate ()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (interactable != null)
            {
                Debug.Log("hi");
                interactable.Interact(gameObject);
            }
        }
	}
}
