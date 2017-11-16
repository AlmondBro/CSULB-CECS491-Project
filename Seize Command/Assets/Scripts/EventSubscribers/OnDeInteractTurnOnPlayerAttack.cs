using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnDeInteractTurnOnPlayerAttack : MonoBehaviour
{
    void OnEnable()
    {
        GetComponentInParent<AbstractSeat>().onDeInteract += TurnOnPlayerAttack;
    }

    void OnDisable()
    {
        if (GetComponentInParent<AbstractSeat>())
        {
            GetComponentInParent<AbstractSeat>().onDeInteract += TurnOnPlayerAttack;
        }
    }

    void TurnOnPlayerAttack(GameObject interactor)
    {
        interactor.GetComponent<PlayerAttackManager>().enabled = true;
    }
}
