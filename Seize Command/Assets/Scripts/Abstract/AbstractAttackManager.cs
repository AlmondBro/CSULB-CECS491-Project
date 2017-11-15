using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractAttackManager : MonoBehaviour
{
    [SerializeField] AbstractWeaponFireManager weapon;

    protected virtual void Attack()
    {
        weapon.Fire();
    }
}
