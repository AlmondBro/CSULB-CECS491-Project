using System;
using System.Collections.Generic;
using UnityEngine;

public class OnBoardTurnOffPlayerShipAttack : AbstractSubscribers<ShipInteractable>
{
    void OnEnable()
    {
        type.onBoard += TurnOffPlayerShipAttack;
    }

    void OnDisable()
    {
        if(type)
        {
            type.onBoard -= TurnOffPlayerShipAttack;
        }
    }

    void TurnOffPlayerShipAttack(GameObject ship)
    {
        ship.GetComponent<AbstractAttackManager>().enabled = false;
    }
}
