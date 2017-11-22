using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnDeInteractReturnPosition : AbstractSeatSubscriber
{
    [SerializeField] Transform returnPosition;

    void OnEnable()
    {
        seat.onDeInteract += ReturnPosition;
    }

    void OnDisable()
    {
        if (seat)
        {
            seat.onDeInteract -= ReturnPosition;
        }
    }

    void ReturnPosition(GameObject interactor)
    {
        Transform parent = interactor.transform.parent;

        parent.position = returnPosition.position;
        parent.rotation = returnPosition.rotation; 
    }
}
