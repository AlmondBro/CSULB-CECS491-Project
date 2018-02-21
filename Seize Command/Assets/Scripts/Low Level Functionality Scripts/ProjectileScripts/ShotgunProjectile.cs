using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotgunProjectile : AbstractProjectile
{
    [SerializeField]
    float projectileSpeed;

    protected override void Start()
    {
        base.Start();
        SetProjectileSpeed();
    }

    void SetProjectileSpeed()
    {
        rb.velocity = transform.up * projectileSpeed;
		rb.velocity += transform.root.GetComponent<Rigidbody2D>().velocity;
	}

    protected override void SendDamage(GameObject ship)
    {
        ship.GetComponent<HealthManager>().TakeDamage(damage);
        Destroy(gameObject);
    }
}
