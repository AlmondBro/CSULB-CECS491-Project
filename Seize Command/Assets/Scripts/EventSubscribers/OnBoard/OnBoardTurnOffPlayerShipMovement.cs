using System;
using System.Collections.Generic;
using UnityEngine;

public class OnBoardTurnOffPlayerShipMovement : AbstractSubscribers<ShipInteractable>
{
    void OnEnable()
    {
        type.onBoard += TurnOffPlayerShipMovement;
    }

    void OnDisable()
    {
        if (type)
        {
            type.onBoard -= TurnOffPlayerShipMovement;
        }
    }

    void TurnOffPlayerShipMovement(GameObject ship)
    {
        ship.GetComponent<AbstractMovementManager>().enabled = false;
    }
}
