using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttackManager : AbstractAttackManager
{
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            Attack();
        }
    }
}
