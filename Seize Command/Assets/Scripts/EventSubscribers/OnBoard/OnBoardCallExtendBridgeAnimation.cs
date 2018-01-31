using System;
using System.Collections.Generic;
using UnityEngine;

public class OnBoardCallExtendBridgeAnimation : AbstractSubscribers<ShipInteractable>
{
    void OnEnable()
    {
        type.onBoard += CallExtendBridgeAnimation;
    }

    void OnDisable()
    {
        if (type)
        {
            type.onBoard -= CallExtendBridgeAnimation;
        }
    }

    void CallExtendBridgeAnimation(GameObject ship)
    {
        ship.GetComponent<Animator>().SetBool(1, true);
    }
}
