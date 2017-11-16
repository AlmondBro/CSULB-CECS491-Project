using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunnerSeat : AbstractSeat
{
    //[SerializeField] AbstractFireManager shipGunnerManager;

    protected override void TakeASeat(GameObject interactor)
    {
        base.TakeASeat(interactor);
        Debug.Log("Gunner Seat On");
        //shipGunnerManager.enabled = true;
    }

    protected override void LeaveSeat(GameObject interactor)
    {
        base.LeaveSeat(interactor);
        Debug.Log("Gunner Seat Off");
        //shipGunnerManager.enabled = false;
    }
}
