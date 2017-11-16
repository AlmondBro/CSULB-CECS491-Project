using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnInteractTurnOffPlayerAim : MonoBehaviour {

	void OnEnable()
    {
        GetComponentInParent<AbstractSeat>().onInteract += TurnOffPlayerAim;
    }

    void OnDisable()
    {
        if (GetComponentInParent<AbstractSeat>())
        {
            GetComponentInParent<AbstractSeat>().onInteract += TurnOffPlayerAim;
        }
    }

    void TurnOffPlayerAim(GameObject interactor)
    {
        interactor.GetComponent<PlayerAimManager>().enabled = false;
    }
}
