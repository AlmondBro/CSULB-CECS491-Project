using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnInteractSetInteractingToTrue : AbstractSeatSubscriber
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
        AbstractInteractionManager manager = interactor.GetComponent<AbstractInteractionManager>();
        manager.IsInteracting = true;
    }
}
