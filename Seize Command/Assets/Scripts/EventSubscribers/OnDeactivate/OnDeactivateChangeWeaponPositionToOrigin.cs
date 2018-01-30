using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnDeactivateChangeWeaponPositionToOrigin : AbstractSubscribers<ShipWeaponControlManager>
{
    [SerializeField] Transform ship;

    void OnEnable()
    {
        type.onDeactivate += ChangeWeaponPositionToOrigin;
    }

    void OnDisable()
    {
        if (type)
        {
            type.onDeactivate -= ChangeWeaponPositionToOrigin;
        }
    }

    void ChangeWeaponPositionToOrigin(AbstractWeapon weapon)
    {
        weapon.transform.parent.rotation = ship.rotation;
    }
}
