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
    }

    protected virtual void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.collider.transform.parent.GetComponent(typeof(IDamageable)))
        {
            GameObject damagedObject = coll.collider.transform.parent.gameObject;
            SendDamage(damagedObject);
        }
    }

    protected abstract void SendDamage(GameObject damagedObject);

    IEnumerator CoDestroyOverTime()
    {
        yield return new WaitForSeconds(lifeTime);
        Destroy(gameObject);
    }
}
