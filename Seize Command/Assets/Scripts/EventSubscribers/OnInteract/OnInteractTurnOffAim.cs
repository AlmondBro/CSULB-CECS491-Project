using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnInteractTurnOffAim : AbstractSubscribers<AbstractSeat>
{
	void OnEnable()
    {
        type.onInteract += TurnOffPlayerAim;
    }

    void OnDisable()
    {
        if (type)
        {
            type.onInteract += TurnOffPlayerAim;
        }
    }

    void TurnOffPlayerAim(GameObject interactor)
    {
        interactor.GetComponentInParent<AbstractAimManager>().enabled = false;
    }
}
