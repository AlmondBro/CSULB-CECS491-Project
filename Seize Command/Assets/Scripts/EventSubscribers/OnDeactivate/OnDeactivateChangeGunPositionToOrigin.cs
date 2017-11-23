using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnDeactivateChangeGunPositionToOrigin : AbstractShipSubscribers
{
    void OnEnable()
    {
        control.onDeactivate += ChangeGunPositionToOrigin;
    }

    void OnDisable()
    {
        if (control)
        {
            control.onDeactivate -= ChangeGunPositionToOrigin;
        }
    }

    void ChangeGunPositionToOrigin(AbstractWeaponManager cannon)
    {
        cannon.gameObject.GetComponent<AbstractAimManager>().enabled = false;
    }
}
