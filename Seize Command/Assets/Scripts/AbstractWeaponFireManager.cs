using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractWeaponFireManager: MonoBehaviour, IFireable
{
    // To Do: make an AbstractProjectile class
    [SerializeField] protected GameObject proj;
    [SerializeField] protected Transform projSpawnPoint;

    public abstract void Fire();
}
