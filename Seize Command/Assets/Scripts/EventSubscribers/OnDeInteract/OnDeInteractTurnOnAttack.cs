using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnDeInteractTurnOnAttack : AbstractSeatSubscriber
{
    void OnEnable()
    {
        seat.onDeInteract += TurnOnPlayerAttack;
    }

    void OnDisable()
    {
        if (seat)
        {
            seat.onDeInteract += TurnOnPlayerAttack;
        }
    }

    void TurnOnPlayerAttack(GameObject interactor)
    {
        interactor.GetComponentInParent<AbstractAttackManager>().enabled = true;
    }
}
