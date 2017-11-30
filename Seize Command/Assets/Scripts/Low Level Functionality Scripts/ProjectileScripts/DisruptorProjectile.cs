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

    void OnCollisionEnter2D(Collision2D coll)
    {
        if(coll.gameObject.CompareTag("Ship"))
        {
            GameObject ship = coll.gameObject;

            SendDamage(ship);
            StartCoroutine(DisruptShip(ship));
        }
    }

    protected override void SendDamage(GameObject ship)
    {
        ship.GetComponent<HealthManager>().TakeDamage(projectileDamage);
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
