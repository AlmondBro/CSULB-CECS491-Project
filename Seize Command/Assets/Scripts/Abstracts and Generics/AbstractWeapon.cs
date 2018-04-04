using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractWeapon: MonoBehaviour, IFireable
{
    [SerializeField] protected AbstractProjectile proj;
    [SerializeField] protected Transform projSpawnPoint;
    [SerializeField] protected GameObject parent;
    [SerializeField] float cooldown;

    bool readyToFire;

    protected virtual void Start()
    {
        readyToFire = true;
    }

    public virtual void Fire()
    {
        if(proj && readyToFire)
        {
            Instantiate();
            StartCoroutine(CoStartCooldown());
        }
    }

    protected abstract void Instantiate();

    protected abstract void IgnoreCollisions(GameObject projectileObject);

    IEnumerator CoStartCooldown()
    {
        readyToFire = false;
        yield return new WaitForSeconds(cooldown);
        readyToFire = true;
    }
}
