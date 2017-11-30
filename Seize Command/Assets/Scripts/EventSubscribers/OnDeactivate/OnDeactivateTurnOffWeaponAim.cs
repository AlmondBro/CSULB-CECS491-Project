using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnDeactivateTurnOffWeaponAim : AbstractShipSubscribers
{
    [SerializeField] Transform shipRotation;

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

    void TurnOffWeaponAim(AbstractWeapon weapon)
    {
        weapon.gameObject.GetComponent<AbstractAimManager>().enabled = false;
    }
}
