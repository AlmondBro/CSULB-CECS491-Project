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
        FindEnemyWithMouseClick();
    }

    void FixedUpdate()
    {
        transform.position = Vector2.MoveTowards(transform.position, target.transform.position, projectileSpeed * Time.deltaTime);
    }

    void FindEnemyWithMouseClick()
    {
        Vector2 mouseLocation = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        target = Physics2D.OverlapCircle(mouseLocation, 1).gameObject;
    }

    protected override void SendDamage(GameObject damagedObject)
    {
        IDamageable damageable = damagedObject.GetComponent<IDamageable>();
        damageable.TakeDamage(damage);
        Destroy(gameObject);
    }
}
