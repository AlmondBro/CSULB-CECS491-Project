using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnDeactivateTurnOffWeaponAim : AbstractSubscribers<ShipWeaponControlManager>
{
    void OnEnable()
    {
        type.onDeactivate += TurnOffWeaponAim;
    }

    void OnDisable()
    {
        if (type)
        {
            type.onDeactivate -= TurnOffWeaponAim;
        }
    }

    void TurnOffWeaponAim(AbstractWeapon weapon)
    {
        weapon.gameObject.GetComponent<AbstractAimManager>().enabled = false;
    }
}
