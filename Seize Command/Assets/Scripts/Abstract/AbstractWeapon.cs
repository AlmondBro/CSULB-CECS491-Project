using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractWeapon: MonoBehaviour, IFireable
{
    [SerializeField] protected AbstractProjectile proj;
    [SerializeField] protected Transform projSpawnPoint;

    public abstract void Fire();
}
