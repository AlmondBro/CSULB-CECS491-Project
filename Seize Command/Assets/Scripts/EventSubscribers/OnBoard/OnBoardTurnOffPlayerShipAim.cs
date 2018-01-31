using System;
using System.Collections.Generic;
using UnityEngine;

public class OnBoardTurnOffPlayerShipAim : AbstractSubscribers<ShipInteractable>
{
    void OnEnable()
    {
        type.onBoard += TurnOffPlayerShipAim;
    }

    void OnDisable()
    {
        if (type)
        {
            type.onBoard -= TurnOffPlayerShipAim;
        }
    }

    void TurnOffPlayerShipAim(GameObject ship)
    {
        ship.GetComponent<AbstractAimManager>().enabled = false;
    }
}
