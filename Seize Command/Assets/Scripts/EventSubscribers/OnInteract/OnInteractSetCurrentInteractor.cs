using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnInteractSetCurrentInteractor : AbstractSeatSubscriber
{
    void OnEnable()
    {
        seat.onInteract += SetInteractingToTrue;
    }

    void OnDisable()
    {
        if(seat)
        {
            seat.onInteract -= SetInteractingToTrue;
        }
    }

    void SetInteractingToTrue(GameObject interactor)
    {
        seat.CurrentInteractor = interactor;
    }
}
