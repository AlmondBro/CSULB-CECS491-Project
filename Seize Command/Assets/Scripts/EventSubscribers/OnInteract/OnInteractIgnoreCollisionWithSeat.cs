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
        Collider2D seatColl = GetComponentInParent<Collider2D>();
        Collider2D[] interactorColliders = interactor.GetComponentsInParent<Collider2D>();

        for(int i = 0; i < interactorColliders.Length; i++)
        {
            if(!interactorColliders[i].isTrigger)
            {
                Physics2D.IgnoreCollision(interactorColliders[i], seatColl);
            }
        }
    }
}
