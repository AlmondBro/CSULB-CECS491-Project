using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnDeInteractTurnOnAttack : AbstractSubscribers<AbstractSeat>
{
    void OnEnable()
    {
        type.onDeInteract += TurnOnPlayerAttack;
    }

    void OnDisable()
    {
        if (type)
        {
            type.onDeInteract += TurnOnPlayerAttack;
        }
    }

    void TurnOnPlayerAttack(GameObject interactor)
    {
        interactor.GetComponentInParent<AbstractAttackManager>().enabled = true;
    }
}
