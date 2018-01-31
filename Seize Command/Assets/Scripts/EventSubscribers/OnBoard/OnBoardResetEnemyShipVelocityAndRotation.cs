using System;
using System.Collections.Generic;
using UnityEngine;

public class OnBoardResetEnemyShipVelocityAndRotation : AbstractSubscribers<ShipInteractable>
{
    void OnEnable()
    {
        type.onBoard += ResetEnemyShipVelocityAndRotation;
    }

    void OnDisable()
    {
        if (type)
        {
            type.onBoard -= ResetEnemyShipVelocityAndRotation;
        }
    }

    void ResetEnemyShipVelocityAndRotation(GameObject ship)
    {
        Debug.Log("hi");
        type.transform.root.rotation = new Quaternion(0, 0, 0, 0);
        type.GetComponentInParent<Rigidbody2D>().velocity = new Vector2(0, 0);
    }
}
