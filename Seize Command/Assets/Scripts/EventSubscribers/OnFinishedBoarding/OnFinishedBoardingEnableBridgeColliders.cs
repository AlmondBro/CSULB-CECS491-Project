using System;
using System.Collections.Generic;
using UnityEngine;

public class OnFinishedBoardingEnableBridgeColliders : AbstractSubscribers<OnFinishedBridgeAnimation>
{
    void OnEnable()
    {
        type.onFinishedBoard += SnapPlayerAndEnemyShipsTogether;
    }

    void OnDisable()
    {
        if (type)
        {
            type.onFinishedBoard -= SnapPlayerAndEnemyShipsTogether;
        }
    }

    void SnapPlayerAndEnemyShipsTogether(GameObject ship)
    {
        GameObject bridgeWalls = transform.root.Find("Bridge").Find("Bridge Walls").gameObject;
        bridgeWalls.SetActive(true);
    }
}
