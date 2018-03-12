using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisruptorProjectile : AbstractProjectile
{
    [SerializeField] float projectileSpeed;
    [SerializeField] float disruptTime;

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
        StartCoroutine(DisruptShip(damagedObject));
        Destroy(gameObject);
    }

    IEnumerator DisruptShip(GameObject ship)
    {
        Rigidbody2D shipRb = ship.GetComponent<Rigidbody2D>();
        Vector2 shipVelocity = shipRb.velocity;
        shipRb.velocity = new Vector2(0, 0);

        yield return new WaitForSeconds(disruptTime);

        shipRb.velocity = shipVelocity;
    }
}
