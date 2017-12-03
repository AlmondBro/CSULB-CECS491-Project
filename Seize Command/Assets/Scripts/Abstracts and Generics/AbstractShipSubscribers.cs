using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractShipSubscribers : MonoBehaviour
{
    protected ShipWeaponControlManager control;

    void Awake()
    {
        control = GetComponentInParent<ShipWeaponControlManager>();    
    }
}
