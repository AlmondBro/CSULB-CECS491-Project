using System;
using System.Collections.Generic;
using UnityEngine;

public class OnBoardTurnOffEnemyShipMovement : AbstractSubscribers<ShipInteractable>
{
    void OnEnable()
    {
        type.onBoard += TurnOffEnemyShipMovement;
    }

    void OnDisable()
    {
        if (type)
        {
            type.onBoard -= TurnOffEnemyShipMovement;
        }
    }

    void TurnOffEnemyShipMovement(GameObject ship)
    {
        type.GetComponentInParent<AbstractMovementManager>().enabled = false;
    }
}
