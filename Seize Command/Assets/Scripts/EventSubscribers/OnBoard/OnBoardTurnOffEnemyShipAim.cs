using System;
using System.Collections.Generic;
using UnityEngine;

public class OnBoardTurnOffEnemyShipAim : AbstractSubscribers<ShipInteractable>
{
    void OnEnable()
    {
        type.onBoard += TurnOffEnemyShipAim;
    }

    void OnDisable()
    {
        if (type)
        {
            type.onBoard -= TurnOffEnemyShipAim;
        }
    }

    void TurnOffEnemyShipAim(GameObject ship)
    {
        type.GetComponentInParent<AbstractAimManager>().enabled = false;
    }
}
