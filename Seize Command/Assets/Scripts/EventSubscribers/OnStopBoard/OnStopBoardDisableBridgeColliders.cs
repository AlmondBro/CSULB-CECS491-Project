using System;
using System.Collections.Generic;
using UnityEngine;

public class OnStopBoardDisableBridgeColliders : AbstractSubscribers<ShipInteractable>
{
    void OnEnable()
    {
        type.onStopBoard += DisableBridgeColliders;
    }

    void OnDisable()
    {
        if (type)
        {
            type.onStopBoard -= DisableBridgeColliders;
        }
    }

    void DisableBridgeColliders(GameObject ship)
    {
        GameObject bridgeWalls = ship.transform.Find("Bridge").Find("Bridge Walls").gameObject;
        bridgeWalls.SetActive(false);
    }
}
