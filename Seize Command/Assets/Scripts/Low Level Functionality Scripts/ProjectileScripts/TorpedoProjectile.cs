using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorpedoProjectile : AbstractProjectile
{
    [SerializeField] float forceStrength;

    void FixedUpdate()
    {
        SetProjectileSpeed();   
    }

    void SetProjectileSpeed()
    {
        rb.AddForce(transform.up * forceStrength);
    }

    protected override void SendDamage(GameObject damagedObject)
    {
        IDamageable damageable = damagedObject.GetComponent<IDamageable>();
        damageable.TakeDamage(damage);
        Destroy(gameObject);
    }
}
