using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnInteractTurnOffPlayerAttack : MonoBehaviour {

    void OnEnable()
    {
        GetComponentInParent<AbstractSeat>().onInteract += TurnOffPlayerAttack;
    }

    void OnDisable()
    {
        if (GetComponentInParent<AbstractSeat>())
        {
            GetComponentInParent<AbstractSeat>().onInteract += TurnOffPlayerAttack;
        }
    }

    void TurnOffPlayerAttack(GameObject interactor)
    {
        interactor.GetComponent<PlayerAttackManager>().enabled = false;
    }
}
