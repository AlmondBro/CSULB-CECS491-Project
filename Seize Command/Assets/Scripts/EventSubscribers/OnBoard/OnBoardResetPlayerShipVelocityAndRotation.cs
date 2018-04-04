using System;
using System.Collections.Generic;
using UnityEngine;

public class OnBoardResetPlayerShipVelocityAndRotation : AbstractSubscribers<ShipInteractable>
{
    void OnEnable()
    {
        type.onBoard += ResetPlayerShipVelocityAndRotation;
    }

    void OnDisable()
    {
        if (type)
        {
            type.onBoard -= ResetPlayerShipVelocityAndRotation;
        }
    }

    void ResetPlayerShipVelocityAndRotation(GameObject ship)
    {
        ship.transform.rotation = new Quaternion(0, 0, 0, 0);
        ship.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
    }
}
