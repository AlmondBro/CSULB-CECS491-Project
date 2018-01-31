using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnActivateChangeWeapon : AbstractSubscribers<ShipWeaponControlManager>
{
    void OnEnable()
    {
        type.onActivate += ChangeWeapon;
    }

    void OnDisable()
    {
        if(type)
        {
            type.onActivate -= ChangeWeapon;
        }
    }

    void ChangeWeapon(AbstractWeapon weapon)
    {
        AbstractAttackManager shipAttackManager = GetComponentInParent<AbstractAttackManager>();
        shipAttackManager.Weapon = weapon;
    }
}
