using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileProjectile : AbstractProjectile
{
    [SerializeField] float projectileSpeed;
    GameObject target;

    private void Awake()
    {
        target = GameObject.FindGameObjectWithTag("Target");
    }

    protected override void Start()
    {
        base.Start();
        SetProjectileSpeed();
    }

    void SetProjectileSpeed()
    {
        rb.velocity = transform.up * projectileSpeed;
    }

    private void Update()
    {
        transform.position = Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.y), target.transform.position, projectileSpeed * Time.deltaTime);
    }

    protected override void SendDamage(GameObject ship)
    {
        ship.GetComponent<HealthManager>().TakeDamage(damage);
        Destroy(gameObject);
    }
}
