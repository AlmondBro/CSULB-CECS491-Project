using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : AbstractWeapon
{
    public override void Fire()
    {
        Vector2 mouseLocation = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if(Physics2D.OverlapCircle(mouseLocation, 1))
        {
            GameObject ship = Physics2D.OverlapCircle(mouseLocation, 1).gameObject;
            if(ship.CompareTag("Ship"))
            {
                base.Fire();
            }
        }
    }

    protected override void Instantiate()
    {
        GameObject projectileObject = Instantiate(proj, projSpawnPoint.position, projSpawnPoint.rotation).gameObject;
        IgnoreCollisions(projectileObject);
		projectileObject.transform.parent = transform.root;
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
