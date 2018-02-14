using System;
using System.Collections.Generic;
using UnityEngine;

public class OnFinishedStopBoardSetEnemyShipCurrentInteractorToNull : AbstractSubscribers<OnFinishedBridgeAnimation>
{
    void OnEnable()
    {
        type.onFinishedStopBoard += SetEnemyShipCurrentInteractorToNull;
    }

    void OnDisable()
    {
        if (type)
        {
            type.onFinishedStopBoard -= SetEnemyShipCurrentInteractorToNull;
        }
    }

    void SetEnemyShipCurrentInteractorToNull(GameObject interactable)
    {
        interactable.GetComponentInChildren<ShipInteractable>().CurrentInteractor = null;
    }
}
