using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeamLazer : AbstractProjectile
{
    GameObject enemyShip;

    protected override void OnCollisionEnter2D(Collision2D coll)
    {
        if(coll.gameObject.CompareTag("Ship"))
        {
            enemyShip = coll.gameObject;
            StartCoroutine(DamageOverTime());
        }
    }

    void OnCollisionExit2D(Collision2D coll)
    {
        if(coll.gameObject.Equals(enemyShip))
        {
            StopCoroutine(DamageOverTime());
        }   
    }

    protected override void SendDamage(GameObject damagedObject)
    {
        IDamageable damageable = damagedObject.GetComponent<IDamageable>();
        damageable.TakeDamage(damage);
        Destroy(gameObject);
    }

    IEnumerator DamageOverTime()
    {
        while(true)
        {
            SendDamage(enemyShip);
        }
    }
}
