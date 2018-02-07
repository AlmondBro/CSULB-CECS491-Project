using System;
using System.Collections.Generic;
using UnityEngine;

public class OnBoardTurnOffPlayerShipWeaponControl : AbstractSubscribers<ShipInteractable>
{
    void OnEnable()
    {
        type.onBoard += TurnOffPlayerShipWeaponControl;
    }

    void OnDisable()
    {
        if (type)
        {
            type.onBoard -= TurnOffPlayerShipWeaponControl;
        }
    }

    void TurnOffPlayerShipWeaponControl(GameObject ship)
    {
        ship.GetComponent<ShipWeaponControlManager>().enabled = false;
    }
}
