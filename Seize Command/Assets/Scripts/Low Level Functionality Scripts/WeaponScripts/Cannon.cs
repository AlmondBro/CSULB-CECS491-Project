using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : AbstractWeapon
{
    protected override void Instantiate()
    {
        GameObject projectileObject = Instantiate(proj, projSpawnPoint.position, projSpawnPoint.rotation).gameObject;
        IgnoreCollisions(projectileObject);
		projectileObject.transform.parent = transform.root;
    }

    protected override void IgnoreCollisions(GameObject projectileObject)
    {
        Collider2D projectileCollider = projectileObject.GetComponent<Collider2D>();
        GameObject ship = FindParentWithTag("Ship");
        Collider2D[] shipColliders = ship.GetComponentsInChildren<Collider2D>();

        for (int i = 0; i < shipColliders.Length; i++)
        {
            Physics2D.IgnoreCollision(shipColliders[i], projectileCollider);
        }
    }
}
