using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterProjectile : AbstractProjectile {

    [SerializeField] float projectileSpeed;

    protected override void Start()
    {
        base.Start();
        SetProjectileSpeed();
    }

    protected override void OnCollisionEnter2D(Collision2D coll)
	    {
		//checks if the game object is a character, a player, or the AI for it 
		if(coll.gameObject.CompareTag("Character") || coll.gameObject.CompareTag("Player") || coll.gameObject.CompareTag("AI"))
        {
            base.OnCollisionEnter2D(coll);
        }

        Destroy(gameObject);
    }

    void SetProjectileSpeed()
    {
        rb.velocity = transform.up * projectileSpeed;
    }

    protected override void SendDamage(GameObject ship)
    {
        ship.GetComponent<HealthManager>().TakeDamage(damage);
        Destroy(gameObject);
    }

}
