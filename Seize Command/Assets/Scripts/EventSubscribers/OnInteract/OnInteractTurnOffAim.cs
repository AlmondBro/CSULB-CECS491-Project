using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnInteractTurnOffAim : AbstractSeatSubscriber
{
	void OnEnable()
    {
        seat.onInteract += TurnOffPlayerAim;
    }

    void OnDisable()
    {
        if (seat)
        {
            seat.onInteract += TurnOffPlayerAim;
        }
    }

    void TurnOffPlayerAim(GameObject interactor)
    {
        interactor.GetComponentInParent<AbstractAimManager>().enabled = false;
    }
}
