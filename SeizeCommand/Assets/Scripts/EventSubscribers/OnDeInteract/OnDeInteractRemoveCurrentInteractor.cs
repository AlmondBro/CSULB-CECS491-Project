using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnDeInteractRemoveCurrentInteractor : AbstractSubscribers<AbstractSeat>
{
    void OnEnable()
    {
        type.onDeInteract += SetInteractingToFalse;
    }

    void OnDisable()
    {
        if (type)
        {
            type.onDeInteract -= SetInteractingToFalse;
        }
    }

    void SetInteractingToFalse(GameObject interactor)
    {
        type.CurrentInteractor = null;
    }
}
