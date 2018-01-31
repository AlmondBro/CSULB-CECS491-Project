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
        interactor.transform.position = returnPosition.position;
        interactor.transform.rotation = returnPosition.rotation; 
    }
}
