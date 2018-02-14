using System;
using System.Collections.Generic;
using UnityEngine;

public class OnFinishedBridgeAnimation : MonoBehaviour
{
    public delegate void InteractableAction(GameObject interactable);
    public event InteractableAction onFinishedBoard;
    public event InteractableAction onFinishedStopBoard;

    void FinishedExtendBridgeAnimation()
    {
        GameObject interactable = GetComponentInChildren<ShipInteractor>().IsBoarding;
        onFinishedBoard(interactable);
    }

    void FinishedReverseBridgeAnimation()
    {
        GameObject interactable = GetComponentInChildren<ShipInteractor>().IsBoarding;
        onFinishedStopBoard(interactable);
    }
}