using System;
using System.Collections.Generic;
using UnityEngine;

public class OnFinishedBoardingOpenBridgeDoors : AbstractSubscribers<OnExtendBridgeFinishedAnimationEvent>
{
    void OnEnable()
    {
        type.onFinishedBoard += OpenBridgeDoors;
    }

    void OnDisable()
    {
        if (type)
        {
            type.onFinishedBoard -= OpenBridgeDoors;
        }
    }

    void OpenBridgeDoors(GameObject interactable)
    {
        type.GetComponentInChildren<Door>().Disable();
        interactable.GetComponentInChildren<Door>().Disable();
    }
}
