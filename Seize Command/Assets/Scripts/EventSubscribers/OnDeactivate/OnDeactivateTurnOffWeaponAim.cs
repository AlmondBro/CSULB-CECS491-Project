using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnDeactivateTurnOffWeaponAim : AbstractShipSubscribers
{
    void OnEnable()
    {
        control.onDeactivate += TurnOffWeaponAim;
    }

    void OnDisable()
    {
        if (control)
        {
            control.onDeactivate -= TurnOffWeaponAim;
        }
    }

    void TurnOffWeaponAim(AbstractWeaponManager cannon)
    {
        cannon.transform.parent.rotation = Quaternion.Euler(0, 0, 0);
    }
}
