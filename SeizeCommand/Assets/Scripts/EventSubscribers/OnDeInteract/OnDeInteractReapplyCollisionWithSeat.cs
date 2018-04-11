using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnDeInteractReapplyCollisionWithSeat : AbstractSubscribers<AbstractSeat>
{
    void OnEnable()
    {
        type.onDeInteract += ReapplyCollisionWithSeat;
    }

    void OnDisable()
    {
        if (type)
        {
            type.onDeInteract -= ReapplyCollisionWithSeat;
        }
    }

    void ReapplyCollisionWithSeat(GameObject interactor)
    {
        Collider2D seatColl = GetComponent<Collider2D>();
        Collider2D[] interactorColl = interactor.GetComponents<Collider2D>();

        for(int i = 0; i < interactorColl.Length; i++)
        {
            if(!interactorColl[i].isTrigger)
            {
                Physics2D.IgnoreCollision(interactorColl[i], seatColl, false);
            }
        }
    }
}
