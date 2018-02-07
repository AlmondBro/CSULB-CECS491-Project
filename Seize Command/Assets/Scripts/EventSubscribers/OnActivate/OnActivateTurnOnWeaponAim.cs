using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnActivateTurnOnWeaponAim : AbstractSubscribers<ShipWeaponControlManager>
{
    void OnEnable()
    {
        type.onActivate += TurnOnWeaponAim;
    }

    void OnDisable()
    {
        if (type)
        {
            type.onActivate -= TurnOnWeaponAim;
        }
    }

    void TurnOnWeaponAim(AbstractWeapon weapon)
    {
        weapon.gameObject.GetComponent<AbstractAimManager>().enabled = true;
    }
}
