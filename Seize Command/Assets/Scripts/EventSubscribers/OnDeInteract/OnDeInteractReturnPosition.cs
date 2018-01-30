using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnDeInteractReturnPosition : AbstractSubscribers<AbstractSeat>
{
    [SerializeField] Transform returnPosition;

    void OnEnable()
    {
        type.onDeInteract += ReturnPosition;
    }

    void OnDisable()
    {
        if (type)
        {
            type.onDeInteract -= ReturnPosition;
        }
    }

    void ReturnPosition(GameObject interactor)
    {
        Transform parent = interactor.transform.parent;

        parent.position = returnPosition.position;
        parent.rotation = returnPosition.rotation; 
    }
}
