using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnDeInteractTurnOnMovement : AbstractSeatSubscribers
{
    void OnEnable()
    {
        seat.onDeInteract += TurnOnPlayerMovement;
    }

    void OnDisable()
    {
        if (seat)
        {
            seat.onDeInteract -= TurnOnPlayerMovement;
        }
    }

    void TurnOnPlayerMovement(GameObject interactor)
    {
        interactor.GetComponentInParent<AbstractMovementManager>().enabled = true;
    }
}
