using System;
using System.Collections.Generic;
using UnityEngine;

public class OnBoardTurnOffEnemyShipWeaponControl : AbstractSubscribers<ShipInteractable>
{
    void OnEnable()
    {
        type.onBoard += TurnOffEnemyShipWeaponControl;
    }

    void OnDisable()
    {
        if (type)
        {
            type.onBoard -= TurnOffEnemyShipWeaponControl;
        }
    }

    void TurnOffEnemyShipWeaponControl(GameObject ship)
    {
        type.GetComponentInParent<ShipWeaponControlManager>().enabled = false;
    }
}
