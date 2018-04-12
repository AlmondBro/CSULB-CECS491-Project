using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipAttackManager : AbstractAttackManager {

    void Start()
    {
        enabled = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Attack();
        }
    }
}
