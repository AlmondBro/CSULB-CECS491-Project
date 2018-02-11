using System;
using System.Collections.Generic;
using UnityEngine;

public class OnStopBoardCallReservseBridgeAnimation : AbstractSubscribers<ShipInteractable>
{
    void OnEnable()
    {
        type.onStopBoard += CallReverseBridgeAnimation;
    }

    void OnDisable()
    {
        if (type)
        {
            type.onStopBoard -= CallReverseBridgeAnimation;
        }
    }

    void CallReverseBridgeAnimation(GameObject ship)
    {
        ship.GetComponent<Animator>().SetTrigger("ReverseBridge");
    }
}
