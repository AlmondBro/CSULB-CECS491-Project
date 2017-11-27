using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicalProjectile: AbstractProjectile
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

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.CompareTag("Ship"))
        {
            GameObject ship = coll.gameObject;
            SendDamage(ship);
        }
    }

    protected override void SendDamage(GameObject ship)
    {
        ship.GetComponent<HealthManager>().TakeDamage(projectileDamage);
        Destroy(gameObject);
    }
}
