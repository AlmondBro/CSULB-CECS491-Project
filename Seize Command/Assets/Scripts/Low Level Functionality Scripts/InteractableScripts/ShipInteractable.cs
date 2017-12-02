using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipInteractable : MonoBehaviour,IInteractable
{
    GameObject currentInteractor;

    public void Interact(GameObject ship) //the ship that interacts with this ship
	{
		if(currentInteractor !=  null)
        {
            if(ship.Equals(currentInteractor))
            {
                DeBoard(ship);
            }
        }
        else
        {
            Board(ship);
        }
	}

    void Board(GameObject ship)
    {
        // 'gameObject' the ship that holds this script
        currentInteractor = ship;

        gameObject.transform.rotation = new Quaternion(0, 0, 0, 0);
        gameObject.GetComponent<ConstantForce2D>().enabled = false;
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);

        ship.transform.rotation = new Quaternion(0, 0, 0, 0);
        ship.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        Debug.Log("Boarding initiated!");

        //lock ships in place
        ship.transform.position = gameObject.transform.position - new Vector3(10, 0, 0);

        ship.GetComponent<AbstractAimManager>().enabled = false;
        ship.GetComponent<AbstractMovementManager>().enabled = false;
    }

    void DeBoard(GameObject ship)
    {
        currentInteractor = null;

        gameObject.GetComponent<ConstantForce2D>().enabled = true;

        Debug.Log("Stopped Boarding");

        ship.GetComponent<AbstractAimManager>().enabled = true;
        ship.GetComponent<AbstractMovementManager>().enabled = true;
    }
}
