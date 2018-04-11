using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonProjectile : AbstractProjectile
{
    [SerializeField] float projectileSpeed;

    protected override void Start()
    {
        base.Start();
        SetProjectileSpeed();
    }

    void SetProjectileSpeed()
    {
        rb.velocity = transform.up * projectileSpeed;
    }

    protected override void SendDamage(GameObject damagedObject)
    {
        IDamageable damageable = damagedObject.GetComponent<IDamageable>();
        damageable.TakeDamage(damage);
        Destroy(gameObject);
    }
}