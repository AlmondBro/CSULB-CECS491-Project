using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunnerSeat : AbstractSeat
{
    AbstractAttackManager shipAttackManager;
    ShipWeaponControlManager shipWeaponControlManager;
    ShipInteractor shipInteractor;
    ShipInteractable shipInteractable;

    void Awake()
    {
        shipAttackManager = GetComponentInParent<AbstractAttackManager>();
        shipWeaponControlManager = GetComponentInParent<ShipWeaponControlManager>();
        shipInteractor = transform.root.GetComponentInChildren<ShipInteractor>();
        shipInteractable = transform.root.GetComponentInChildren<ShipInteractable>();
    }

    protected override void TakeASeat(GameObject interactor)
    {
        base.TakeASeat(interactor);

        if (!shipInteractor.IsBoarding && !shipInteractable.CurrentInteractor)
        {
            shipAttackManager.enabled = true;
            shipWeaponControlManager.enabled = true;
        }
    }

    protected override void LeaveSeat(GameObject interactor)
    {
        base.LeaveSeat(interactor);

        if (!shipInteractor.IsBoarding && !shipInteractable.CurrentInteractor)
        {
            shipAttackManager.enabled = false;
            shipWeaponControlManager.enabled = false;
        }
    }
}
