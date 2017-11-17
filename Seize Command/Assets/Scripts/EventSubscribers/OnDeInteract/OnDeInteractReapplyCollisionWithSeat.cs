using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnDeInteractReapplyCollisionWithSeat : AbstractSeatSubscriber
{
    void OnEnable()
    {
        seat.onDeInteract += ReapplyCollisionWithSeat;
    }

    void OnDisable()
    {
        if (seat)
        {
            seat.onDeInteract -= ReapplyCollisionWithSeat;
        }
    }

    void ReapplyCollisionWithSeat(GameObject interactor)
    {
        Collider2D seatColl = GetComponentInParent<Collider2D>();
        Collider2D[] interactorColl = interactor.GetComponentsInParent<Collider2D>();

        for(int i = 0; i < interactorColl.Length; i++)
        {
            if(!interactorColl[i].isTrigger)
            {
                Physics2D.IgnoreCollision(interactorColl[i], seatColl, false);
            }
        }
    }
}
