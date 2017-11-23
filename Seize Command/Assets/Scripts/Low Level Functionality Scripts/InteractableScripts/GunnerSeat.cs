using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunnerSeat : AbstractSeat
{
    AbstractAttackManager shipAttackManager;
    ShipWeaponControlManager shipWeaponControlManager;

    void Start()
    {
        shipAttackManager = GetComponentInParent<AbstractAttackManager>();
        shipWeaponControlManager = GetComponentInParent<ShipWeaponControlManager>();
    }

    protected override void TakeASeat(GameObject interactor)
    {
        base.TakeASeat(interactor);
        Debug.Log("Gunner Seat On");
        shipAttackManager.enabled = true;
        shipWeaponControlManager.enabled = true;
    }

    protected override void LeaveSeat(GameObject interactor)
    {
        base.LeaveSeat(interactor);
        Debug.Log("Gunner Seat Off");
        shipAttackManager.enabled = false;
        shipWeaponControlManager.enabled = false;
    }
}
