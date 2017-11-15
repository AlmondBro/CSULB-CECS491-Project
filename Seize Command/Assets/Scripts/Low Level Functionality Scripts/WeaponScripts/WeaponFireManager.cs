using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponFireManager: AbstractWeaponFireManager
{
    public override void Fire()
    {
        if(proj)
        {
            GameObject projectileObject = Instantiate(proj, projSpawnPoint.position, projSpawnPoint.rotation).gameObject;

            Collider2D projectileCollider = projectileObject.GetComponent<Collider2D>();
            Collider2D parentCollider = transform.parent.GetComponent<Collider2D>();
            Physics2D.IgnoreCollision(parentCollider, projectileCollider);
        }
    }
}
