using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractAttackManager : MonoBehaviour
{
    public IFireable Weapon { get; set; }

    protected virtual void Attack()
    {
        if(Weapon != null)
        {
            Weapon.Fire();
        }
    }
}
