using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractAttackManager : MonoBehaviour
{
    IFireable weapon;

    void Start()
    {
        weapon = GetComponentInChildren<IFireable>();
    }

    protected virtual void Attack()
    {
        weapon.Fire();
    }
}
