using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PilotSeat : AbstractSeat
{
    AbstractMovementManager shipMovementManager;

    void Awake()
    {
        shipMovementManager = GetComponentInParent<AbstractMovementManager>();
    }

    protected override void TakeASeat(GameObject interactor)
    {
        base.TakeASeat(interactor);
        Debug.Log("Pilot Seat On");
        shipMovementManager.enabled = true;
    }

    protected override void LeaveSeat(GameObject interactor)
    {
        base.LeaveSeat(interactor);
        Debug.Log("Pilot Seat Off");
        shipMovementManager.enabled = false;
    }
}
