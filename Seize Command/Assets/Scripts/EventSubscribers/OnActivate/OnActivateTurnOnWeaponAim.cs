using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnActivateTurnOnWeaponAim : AbstractShipSubscribers
{
    void OnEnable()
    {
        control.onActivate += TurnOnWeaponAim;
    }

    void OnDisable()
    {
        if (control)
        {
            control.onActivate -= TurnOnWeaponAim;
        }
    }

    void TurnOnWeaponAim(AbstractWeapon cannon)
    {
        cannon.gameObject.GetComponent<AbstractAimManager>().enabled = true;
    }
}
