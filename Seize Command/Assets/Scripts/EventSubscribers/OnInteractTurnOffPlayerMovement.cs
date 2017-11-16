using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnInteractTurnOffPlayerMovement : MonoBehaviour {

    void OnEnable()
    {
        GetComponentInParent<AbstractSeat>().onInteract += TurnOffPlayerMovement;
    }

    void OnDisable()
    {
        if(GetComponentInParent<AbstractSeat>())
        {
            GetComponentInParent<AbstractSeat>().onInteract += TurnOffPlayerMovement;
        }
    }

    void TurnOffPlayerMovement(GameObject interactor)
    {
        interactor.GetComponent<PlayerMovementManager>().enabled = false;
    }
}
