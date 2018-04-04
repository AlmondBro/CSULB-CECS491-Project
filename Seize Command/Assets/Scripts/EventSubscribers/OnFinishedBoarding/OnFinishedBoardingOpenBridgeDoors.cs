using System;
using System.Collections.Generic;
using UnityEngine;

public class OnFinishedBoardingOpenBridgeDoors : AbstractSubscribers<OnFinishedBridgeAnimation>
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
        type.GetComponentInChildren<Door>().GetComponent<BoxCollider2D>().isTrigger = true;
        interactable.GetComponentInChildren<Door>().GetComponent<BoxCollider2D>().isTrigger = true;
    }
}
