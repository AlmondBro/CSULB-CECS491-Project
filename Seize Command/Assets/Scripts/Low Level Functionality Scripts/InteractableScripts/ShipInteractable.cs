using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipInteractable : MonoBehaviour, IInteractable
{
    public delegate void InteractableAction(GameObject interactor);
    public event InteractableAction onBoard;

    GameObject currentInteractor;

    public void Interact(GameObject interactor) //the ship that interacts with this ship
	{
        if (currentInteractor ==  null)
        {
            Board(interactor);
        }
	}

    void Board(GameObject interactor)
    {
        onBoard(interactor);

        /*
        GameObject ship = boardZone.transform.parent.gameObject;
        if (ship.CompareTag("Ship"))
        {
            // 'gameObject' the ship that holds this script
            currentInteractor = ship;
            boardZone.GetComponent<ShipInteractor>().Interacting = true;

            gameObject.transform.parent.rotation = new Quaternion(0, 0, 0, 0);
            gameObject.GetComponentInParent<Rigidbody2D>().velocity = new Vector2(0, 0);

            ship.transform.rotation = new Quaternion(0, 0, 0, 0);
            ship.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            Debug.Log("Boarding initiated!");

            Door door1 = ship.GetComponentInChildren<Door>();
            Door door2 = gameObject.transform.parent.gameObject.GetComponentInChildren <Door>();

            door1.Disable();
            door2.Disable();

            gameObject.transform.parent.GetComponent<AbstractAimManager>().enabled = false;
            gameObject.transform.parent.GetComponent<AbstractMovementManager>().enabled = false;
            gameObject.transform.parent.GetComponent<AbstractAttackManager>().enabled = false;
            gameObject.transform.parent.GetComponent<ShipWeaponControlManager>().enabled = false;

            //lock ships in place
            ship.transform.position = gameObject.transform.parent.position - new Vector3(20, 2.5f, 0);

            ship.GetComponent<AbstractAimManager>().enabled = false;
            ship.GetComponent<AbstractMovementManager>().enabled = false;
            ship.GetComponent<AbstractAttackManager>().enabled = false;
            ship.GetComponent<ShipWeaponControlManager>().enabled = false;
        }
        */
    }

    /*
    void DeBoard(GameObject boardZone)
    {
        GameObject ship = boardZone.transform.parent.gameObject;

        currentInteractor = null;
        boardZone.GetComponent<ShipInteractor>().Interacting = false;

        Debug.Log("Stopped Boarding");
    }
    */
}
