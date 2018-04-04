using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnInteractIgnoreCollisionWithSeat : AbstractSubscribers<AbstractSeat>
{
    void OnEnable()
    {
        type.onInteract += IgnoreCollisionWithSeat;
    }

    void OnDisable()
    {
        if (type)
        {
            type.onInteract -= IgnoreCollisionWithSeat;
        }
    }

    void IgnoreCollisionWithSeat(GameObject interactor)
    {
        Collider2D seatColl = GetComponent<Collider2D>();
        Collider2D interactorCollider = interactor.GetComponent<Collider2D>();

        Physics2D.IgnoreCollision(interactorCollider, seatColl);
    }
}
