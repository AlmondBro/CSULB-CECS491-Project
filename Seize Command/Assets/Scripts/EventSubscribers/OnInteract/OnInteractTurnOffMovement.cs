using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnInteractTurnOffMovement : AbstractSeatSubscriber
{
    void OnEnable()
    {
        seat.onInteract += TurnOffPlayerMovement;
    }

    void OnDisable()
    {
        if(seat)
        {
            seat.onInteract -= TurnOffPlayerMovement;
        }
    }

    void TurnOffPlayerMovement(GameObject interactor)
    {
        interactor.GetComponentInParent<AbstractMovementManager>().enabled = false;
    }
}
