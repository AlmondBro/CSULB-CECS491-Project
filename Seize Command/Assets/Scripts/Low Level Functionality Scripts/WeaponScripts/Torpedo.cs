using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torpedo : AbstractWeapon
{
    protected override void Instantiate()
    {
        GameObject projectileObject = Instantiate(proj, projSpawnPoint.position, projSpawnPoint.rotation).gameObject;
        IgnoreCollisions(projectileObject);
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
