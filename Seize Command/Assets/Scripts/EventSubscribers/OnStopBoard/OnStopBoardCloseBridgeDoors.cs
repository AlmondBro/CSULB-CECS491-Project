using System;
using System.Collections.Generic;
using UnityEngine;

public class OnStopBoardCloseBridgeDoors : AbstractSubscribers<ShipInteractable>
{
    void OnEnable()
    {
        type.onStopBoard += CloseBridgeDoors;
    }

    void OnDisable()
    {
        if (type)
        {
            type.onStopBoard -= CloseBridgeDoors;
        }
    }

    void CloseBridgeDoors(GameObject ship)
    {
        type.transform.root.GetComponentInChildren<Door>().GetComponent<BoxCollider2D>().isTrigger = false;
        //type.GetComponentInChildren<Door>().GetComponent<BoxCollider2D>().isTrigger = true;
        ship.GetComponentInChildren<Door>().GetComponent<BoxCollider2D>().isTrigger = false;
    }
}
