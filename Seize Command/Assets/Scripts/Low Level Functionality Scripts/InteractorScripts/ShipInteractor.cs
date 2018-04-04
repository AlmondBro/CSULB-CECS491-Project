using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipInteractor : AbstractInteractionManager
{
    /*
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
    */

    public GameObject IsBoarding { get; set; }

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
                GameObject ship = transform.root.gameObject;
                interactable.Interact(ship);
            }
        }
	}
}