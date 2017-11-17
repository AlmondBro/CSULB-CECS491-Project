using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnDeInteractTurnOnAim : AbstractSeatSubscriber
{
    void OnEnable()
    {
        seat.onDeInteract += TurnOnPlayerAim;
    }

    void OnDisable()
    {
        if (seat)
        {
            seat.onDeInteract -= TurnOnPlayerAim;
        }
    }

    void TurnOnPlayerAim(GameObject interactor)
    {
        interactor.GetComponentInParent<AbstractAimManager>().enabled = true;
    }
}
