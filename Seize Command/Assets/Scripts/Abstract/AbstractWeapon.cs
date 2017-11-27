using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractWeapon: MonoBehaviour, IFireable
{
    // To Do: make an AbstractProjectile class
    [SerializeField] protected PhysicalProjectile proj;
    [SerializeField] protected Transform projSpawnPoint;

    public abstract void Fire();
}
