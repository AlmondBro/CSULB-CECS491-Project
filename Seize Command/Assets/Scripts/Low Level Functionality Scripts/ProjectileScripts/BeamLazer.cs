using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeamLazer : AbstractProjectile
{
    GameObject healthObject;

    void OnTriggerEnter2D(Collider2D coll)
    {
		//Debug.Log (coll.gameObject);
		if (coll.transform.root.GetComponent<HealthManager>())
        {
            healthObject = coll.transform.root.gameObject;
            StartCoroutine(DamageOverTime());
        }
	}

    void OnTriggerExit2D(Collider2D coll)
    {
        if(coll.gameObject.Equals(healthObject))
        {
            StopCoroutine(DamageOverTime());
        }   
    }

	// Needs to be inherited from Abstract class
	protected override void OnCollisionEnter2D(Collision2D coll)
	{
		
	}

    protected override void SendDamage(GameObject healthObject)
    {
		if (healthObject)
		{
			healthObject.GetComponent<HealthManager>().TakeDamage(damage);
		}
        //Destroy(gameObject);
    }

    IEnumerator DamageOverTime()
    {
        while(true)
        {
            SendDamage(healthObject);
			yield return new WaitForSeconds(0.2f);
        }
    }
}
