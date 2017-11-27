using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnActivateChangeWeaponToCannon : AbstractShipSubscribers
{
    void OnEnable()
    {
        control.onActivate += ChangeWeaponToCannon;
    }

    void OnDisable()
    {
        if(control)
        {
            control.onActivate -= ChangeWeaponToCannon;
        }
    }

    void ChangeWeaponToCannon(AbstractWeapon cannon)
    {
        AbstractAttackManager shipAttackManager = GetComponentInParent<AbstractAttackManager>();
        shipAttackManager.Weapon = cannon;
    }
}
