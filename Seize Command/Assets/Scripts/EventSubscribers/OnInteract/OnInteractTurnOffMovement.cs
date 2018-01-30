using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnInteractTurnOffMovement : AbstractSubscribers<AbstractSeat>
{
    void OnEnable()
    {
        type.onInteract += TurnOffPlayerMovement;
    }

    void OnDisable()
    {
        if(type)
        {
            type.onInteract -= TurnOffPlayerMovement;
        }
    }

    void TurnOffPlayerMovement(GameObject interactor)
    {
        interactor.GetComponentInParent<AbstractMovementManager>().enabled = false;
    }
}
