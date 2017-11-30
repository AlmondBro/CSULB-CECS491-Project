using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnDeactivateChangeWeaponPositionToOrigin : AbstractShipSubscribers
{
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
        weapon.transform.parent.rotation = Quaternion.Euler(0, 0, 0);
    }
}
