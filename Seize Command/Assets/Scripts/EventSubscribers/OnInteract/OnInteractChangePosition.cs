using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnInteractChangePosition : AbstractSeatSubscriber
{
    void OnEnable()
    {
        seat.onInteract += ChangePlayerPosition;
    }

    void OnDisable()
    {
        if (seat)
        {
            seat.onInteract -= ChangePlayerPosition;
        }
    }

    void ChangePlayerPosition(GameObject interactor)
    {
        Transform parent = interactor.transform.parent;

        parent.position = transform.position;
        parent.rotation = transform.rotation;
    }
}
