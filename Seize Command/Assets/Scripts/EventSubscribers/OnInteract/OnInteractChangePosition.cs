using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnInteractChangePosition : AbstractSubscribers<AbstractSeat>
{
    void OnEnable()
    {
        type.onInteract += ChangePlayerPosition;
    }

    void OnDisable()
    {
        if (type)
        {
            type.onInteract -= ChangePlayerPosition;
        }
    }

    void ChangePlayerPosition(GameObject interactor)
    {
        Transform parent = interactor.transform.parent;

        parent.position = transform.position;
        parent.rotation = transform.rotation;
    }
}
