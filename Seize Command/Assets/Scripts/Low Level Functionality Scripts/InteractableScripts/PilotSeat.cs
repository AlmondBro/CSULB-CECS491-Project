using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PilotSeat : AbstractSeat
{
    AbstractMovementManager shipMovementManager;
    AbstractAimManager shipAimManager;
    ShipInteractor shipInteractor;
    ShipInteractable shipInteractable;

    void Awake()
    {
        shipMovementManager = GetComponentInParent<AbstractMovementManager>();
        shipAimManager = GetComponentInParent<AbstractAimManager>();
        shipInteractor = transform.root.GetComponentInChildren<ShipInteractor>();
        shipInteractable = transform.root.GetComponentInChildren<ShipInteractable>();
    }

    protected override void TakeASeat(GameObject interactor)
    {
        base.TakeASeat(interactor);

        shipInteractor.enabled = true;
        if(!shipInteractor.IsBoarding && !shipInteractable.CurrentInteractor)
        {
            shipMovementManager.enabled = true;
            shipAimManager.enabled = true;
        }
    }

    protected override void LeaveSeat(GameObject interactor)
    {
        base.LeaveSeat(interactor);

		shipInteractor.enabled = false;
        if(!shipInteractor.IsBoarding)
        {
            shipMovementManager.enabled = false;
            shipAimManager.enabled = false;
        }
    }
}
