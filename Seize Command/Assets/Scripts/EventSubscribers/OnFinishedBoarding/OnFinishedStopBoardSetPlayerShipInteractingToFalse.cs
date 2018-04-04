using System;
using System.Collections.Generic;
using UnityEngine;

public class OnFinishedStopBoardSetPlayerShipInteractingToFalse : AbstractSubscribers<OnFinishedBridgeAnimation>
{
    void OnEnable()
    {
        type.onFinishedStopBoard += SetPlayerShipInteractingToFalse;
    }

    void OnDisable()
    {
        if (type)
        {
            type.onFinishedStopBoard -= SetPlayerShipInteractingToFalse;
        }
    }

    void SetPlayerShipInteractingToFalse(GameObject interactable)
    {
        type.GetComponentInChildren<ShipInteractor>().IsBoarding = null;
    }
}