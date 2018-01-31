using System;
using System.Collections.Generic;
using UnityEngine;

public class OnBoardSetPlayerShipInteractingToTrue : AbstractSubscribers<ShipInteractable>
{
    void OnEnable()
    {
        type.onBoard += SetPlayerShipInteractingToTrue;
    }

    void OnDisable()
    {
        if (type)
        {
            type.onBoard -= SetPlayerShipInteractingToTrue;
        }
    }

    void SetPlayerShipInteractingToTrue(GameObject ship)
    {
        ship.GetComponentInChildren<ShipInteractor>().IsBoarding = true;
    }
}
