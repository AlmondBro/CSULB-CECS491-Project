using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractHealthManager : MonoBehaviour
{
    [SerializeField] float health;

    public float Health
    {
        get
        {
            return health;
        }
        protected set
        {
            health = value;
        }
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if(coll.gameObject.CompareTag("Projectile"))
        {
            PhysicalProjectile physProj = coll.gameObject.GetComponent<PhysicalProjectile>();
            TakeDamage(physProj.ProjectileDamage);
            Destroy(coll.gameObject);
        }
    }

    protected virtual void TakeDamage(float damage)
    {
        Health -= damage;
        CheckHealth();
    }

    void CheckHealth()
    {
        if(Health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
