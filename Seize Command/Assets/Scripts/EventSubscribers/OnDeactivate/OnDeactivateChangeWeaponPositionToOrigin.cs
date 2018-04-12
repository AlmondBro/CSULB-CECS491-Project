using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnDeactivateChangeWeaponPositionToOrigin : AbstractShipSubscribers
{
    [SerializeField] Transform ship;

    void OnEnable()
    {
        control.onDeactivate += ChangeWeaponPositionToOrigin;
    }

    void OnDisable()
    {
        if (control)
        {
            control.onDeactivate -= ChangeWeaponPositionToOrigin;
        }
    }

    void ChangeWeaponPositionToOrigin(AbstractWeapon weapon)
    {
        weapon.transform.parent.rotation = ship.rotation;
    }
}
