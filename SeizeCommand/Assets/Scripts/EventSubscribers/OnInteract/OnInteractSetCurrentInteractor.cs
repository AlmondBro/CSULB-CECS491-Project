using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnInteractSetCurrentInteractor : AbstractSubscribers<AbstractSeat>
{
    void OnEnable()
    {
        type.onInteract += SetInteractingToTrue;
    }

    void OnDisable()
    {
        if(type)
        {
            type.onInteract -= SetInteractingToTrue;
        }
    }

    void SetInteractingToTrue(GameObject interactor)
    {
        type.CurrentInteractor = interactor;
    }
}
