using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotGun : AbstractWeapon
{
    [SerializeField] int shellCount;

    protected override void Instantiate()
    {
        for(int i = 0; i < shellCount; i++)
        {
            GameObject projectileObject = Instantiate(proj, projSpawnPoint.position, projSpawnPoint.rotation * Quaternion.Euler(0, 0, UnityEngine.Random.Range(-40, 40))).gameObject;
            IgnoreCollisions(projectileObject);
        }
    }

    protected override void IgnoreCollisions(GameObject projectileObject)
    {
        Collider2D projectileCollider = projectileObject.GetComponent<Collider2D>();
        Collider2D[] shipColliders = parent.GetComponentsInChildren<Collider2D>();

        for (int i = 0; i < shipColliders.Length; i++)
        {
            Physics2D.IgnoreCollision(shipColliders[i], projectileCollider);
        }
    }
}
