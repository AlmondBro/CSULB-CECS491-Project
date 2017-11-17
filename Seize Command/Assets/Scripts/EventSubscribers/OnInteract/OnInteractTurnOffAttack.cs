using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnInteractTurnOffAttack : AbstractSeatSubscriber
{
    void OnEnable()
    {
        seat.onInteract += TurnOffPlayerAttack;
    }

    void OnDisable()
    {
        if (seat)
        {
            seat.onInteract += TurnOffPlayerAttack;
        }
    }

    void TurnOffPlayerAttack(GameObject interactor)
    {
        interactor.GetComponentInParent<AbstractAttackManager>().enabled = false;
    }
}
