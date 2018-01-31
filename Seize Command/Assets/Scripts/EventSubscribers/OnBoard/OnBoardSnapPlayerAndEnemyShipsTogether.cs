using System;
using System.Collections.Generic;
using UnityEngine;

public class OnBoardSnapPlayerAndEnemyShipsTogether : AbstractSubscribers<ShipInteractable>
{
    void OnEnable()
    {
        type.onBoard += SnapPlayerAndEnemyShipsTogether;
    }

    void OnDisable()
    {
        if (type)
        {
            type.onBoard -= SnapPlayerAndEnemyShipsTogether;
        }
    }

    void SnapPlayerAndEnemyShipsTogether(GameObject ship)
    {
        ship.transform.position = gameObject.transform.root.position - new Vector3(20, 0, 0);
    }
}
