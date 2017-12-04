using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterWeapon : AbstractWeapon
{
    protected override void Instantiate()
    {
        GameObject projectileObject = Instantiate(proj, projSpawnPoint.position, projSpawnPoint.rotation).gameObject;
        IgnoreCollisions(projectileObject);
    }

    protected override void IgnoreCollisions(GameObject projectileObject)
    {
        Collider2D projectileCollider = projectileObject.GetComponent<Collider2D>();
        Collider2D characterCollider = parent.GetComponent<Collider2D>();

        Physics2D.IgnoreCollision(characterCollider, projectileCollider);
    }
}
