using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnDeInteractTurnOnPlayerMovement : MonoBehaviour
{
    void OnEnable()
    {
        GetComponentInParent<AbstractSeat>().onDeInteract += TurnOnPlayerMovement;
    }

    void OnDisable()
    {
        if (GetComponentInParent<AbstractSeat>())
        {
            GetComponentInParent<AbstractSeat>().onDeInteract += TurnOnPlayerMovement;
        }
    }

    void TurnOnPlayerMovement(GameObject interactor)
    {
        interactor.GetComponent<PlayerMovementManager>().enabled = true;
    }
}
