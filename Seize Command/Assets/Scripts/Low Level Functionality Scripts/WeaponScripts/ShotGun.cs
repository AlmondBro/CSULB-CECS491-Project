using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotGun : AbstractWeapon
{

    [SerializeField]
    int num_pellets;

    [SerializeField]
    float scatter_radius;


    public override void Fire()
    {
        if (proj)
        {
            for (int i = 0; i < num_pellets; i++)
            {
                GameObject projectileObject = Instantiate(proj, projSpawnPoint.position, projSpawnPoint.rotation * Quaternion.Euler(0, 0, UnityEngine.Random.Range(-40, 40))).gameObject;

                Collider2D projectileCollider = projectileObject.GetComponent<Collider2D>();
                Collider2D parentCollider = transform.parent.GetComponent<Collider2D>();
                Physics2D.IgnoreCollision(parentCollider, projectileCollider);
            }
        }
    }
}
