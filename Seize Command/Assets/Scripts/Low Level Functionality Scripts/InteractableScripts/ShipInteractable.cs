using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipInteractable : MonoBehaviour, IInteractable
{
    public delegate void InteractableAction(GameObject interactor);
    public event InteractableAction onBoard;

    public GameObject CurrentInteractor { get; set; }

    public void Interact(GameObject interactor) //the ship that interacts with this ship
	{
        if(interactor.CompareTag("Ship"))
        {
            if (CurrentInteractor == null)
            {
                Board(interactor);
            }
        }
	}

    void Board(GameObject interactor)
    {
        onBoard(interactor);
    }
}
