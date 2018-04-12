using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnActivateChangeWeapon : AbstractShipSubscribers
{
    void OnEnable()
    {
        control.onActivate += ChangeWeapon;
    }

    void OnDisable()
    {
        if(control)
        {
            control.onActivate -= ChangeWeapon;
        }
    }

    void ChangeWeapon(AbstractWeapon weapon)
    {
        Debug.Log("hi");
        AbstractAttackManager shipAttackManager = GetComponentInParent<AbstractAttackManager>();
        shipAttackManager.Weapon = weapon;
    }
}
