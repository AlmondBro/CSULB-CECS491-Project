using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnDeInteractTurnOnAim : AbstractSubscribers<AbstractSeat>
{
    void OnEnable()
    {
        type.onDeInteract += TurnOnPlayerAim;
    }

    void OnDisable()
    {
        if (type)
        {
            type.onDeInteract -= TurnOnPlayerAim;
        }
    }

    void TurnOnPlayerAim(GameObject interactor)
    {
        interactor.GetComponentInParent<AbstractAimManager>().enabled = true;
    }
}
