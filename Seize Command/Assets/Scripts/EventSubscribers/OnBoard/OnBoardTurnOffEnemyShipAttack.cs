using System;
using System.Collections.Generic;
using UnityEngine;

public class OnBoardTurnOffEnemyShipAttack : AbstractSubscribers<ShipInteractable>
{
    void OnEnable()
    {
        type.onBoard += TurnOffEnemyShipAttack;
    }

    void OnDisable()
    {
        if (type)
        {
            type.onBoard -= TurnOffEnemyShipAttack;
        }
    }

    void TurnOffEnemyShipAttack(GameObject ship)
    {
        type.GetComponentInParent<AbstractAttackManager>().enabled = false;
    }
}
