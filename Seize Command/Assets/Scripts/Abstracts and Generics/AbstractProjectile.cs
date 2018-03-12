using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public abstract class AbstractProjectile : MonoBehaviour
{
    [SerializeField] protected float damage;
    protected Rigidbody2D rb;

    [SerializeField] float lifeTime;

    protected virtual void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        StartCoroutine(CoDestroyOverTime());

		GetComponent<AudioSource>().Play ();
    }

    protected virtual void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.GetComponent<HealthManager>())
        {
            GameObject objectWithHealth = coll.gameObject;
            SendDamage(objectWithHealth);
        }
    }

    protected abstract void SendDamage(GameObject ship);

    IEnumerator CoDestroyOverTime()
    {
        yield return new WaitForSeconds(lifeTime);
        Destroy(gameObject);
    }
}
