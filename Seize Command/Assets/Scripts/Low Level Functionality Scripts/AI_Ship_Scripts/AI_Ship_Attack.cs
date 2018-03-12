using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AI_Ship_Attack : AbstractAttackManager
{
    AbstractWeapon currentWeapon;
    AbstractAttackManager AI_Ship_Manager;

    protected void Ship_Attack()
    {
        AI_Ship_Manager = GetComponentInParent<AbstractAttackManager>();
        currentWeapon = GetComponentInParent<AbstractWeapon>();
        AI_Ship_Manager.Weapon = currentWeapon;
        Attack();
    }
}