using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnInteractTurnOffAttack : AbstractSubscribers<AbstractSeat>
{
    void OnEnable()
    {
        type.onInteract += TurnOffPlayerAttack;
    }

    void OnDisable()
    {
        if (type)
        {
            type.onInteract += TurnOffPlayerAttack;
        }
    }

    void TurnOffPlayerAttack(GameObject interactor)
    {
        interactor.GetComponentInParent<AbstractAttackManager>().enabled = false;
    }
}
