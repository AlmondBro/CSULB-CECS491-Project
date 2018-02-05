using System;
using System.Collections.Generic;
using UnityEngine;

public class OnExtendBridgeFinishedAnimationEvent : MonoBehaviour
{
    public delegate void InteractableAction(GameObject interactable);
    public event InteractableAction onFinishedBoard;

    void FinishedExtendBridgeAnimation()
    {
        GameObject interactable = GetComponentInChildren<ShipInteractor>().IsBoarding;
        onFinishedBoard(interactable);
    }
}