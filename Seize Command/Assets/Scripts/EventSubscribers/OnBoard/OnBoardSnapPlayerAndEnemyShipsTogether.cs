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
        Transform playerShipBoardingSnapLocation = ship.transform.Find("Boarding Zone").transform;
        Transform enemyShipBoardingSnapLocation = transform.root.Find("Boarding Zone").transform;

        Vector2 differenceInPositions = enemyShipBoardingSnapLocation.position - playerShipBoardingSnapLocation.position;
        //Debug.Log(differenceInPositions);
        ship.transform.position += (Vector3)differenceInPositions;
    }
}
