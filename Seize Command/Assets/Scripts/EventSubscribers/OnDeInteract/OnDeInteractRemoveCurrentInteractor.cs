using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnDeInteractRemoveCurrentInteractor : AbstractSeatSubscribers
{
    void OnEnable()
    {
        seat.onDeInteract += SetInteractingToFalse;
    }

    void OnDisable()
    {
        if (seat)
        {
            seat.onDeInteract -= SetInteractingToFalse;
        }
    }

    void SetInteractingToFalse(GameObject interactor)
    {
        seat.CurrentInteractor = null;
    }
}
