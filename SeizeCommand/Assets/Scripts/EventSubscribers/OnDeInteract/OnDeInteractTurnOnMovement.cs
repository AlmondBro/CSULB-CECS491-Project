using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnDeInteractTurnOnMovement : AbstractSubscribers<AbstractSeat>
{
    void OnEnable()
    {
        type.onDeInteract += TurnOnPlayerMovement;
    }

    void OnDisable()
    {
        if (type)
        {
            type.onDeInteract -= TurnOnPlayerMovement;
        }
    }

    void TurnOnPlayerMovement(GameObject interactor)
    {
        interactor.GetComponentInParent<AbstractMovementManager>().enabled = true;
    }
}
