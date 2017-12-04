using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractAttackManager : MonoBehaviour
{
    public IFireable Weapon
    {
        get
        {
            return weapon;
        }
        set
        {
            weapon = value;
        }
    }

    private IFireable weapon;

    protected virtual void Attack()
    {
        if(weapon != null)
        {
            weapon.Fire();
        }
    }
}
