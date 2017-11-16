using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnDeInteractTurnOnPlayerAim : MonoBehaviour
{
    void OnEnable()
    {
        GetComponentInParent<AbstractSeat>().onDeInteract += TurnOnPlayerAim;
    }

    void OnDisable()
    {
        if (GetComponentInParent<AbstractSeat>())
        {
            GetComponentInParent<AbstractSeat>().onDeInteract += TurnOnPlayerAim;
        }
    }

    void TurnOnPlayerAim(GameObject interactor)
    {
        interactor.GetComponent<PlayerAimManager>().enabled = true;
    }
}
