using System;
using System.Collections.Generic;
using UnityEngine;

public class OnBoardSetEnemyShipCurrentInteractor : AbstractSubscribers<ShipInteractable>
{
    void OnEnable()
    {
        type.onBoard += SetEnemyShipCurrentInteractor;
    }

    void OnDisable()
    {
        if (type)
        {
            type.onBoard -= SetEnemyShipCurrentInteractor;
        }
    }

    void SetEnemyShipCurrentInteractor(GameObject ship)
    {
        type.GetComponentInParent<ShipInteractable>().CurrentInteractor = ship;
    }
}
