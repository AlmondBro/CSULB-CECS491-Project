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
        Debug.Log(coll.gameObject);
        if (coll.gameObject.GetComponent(typeof(IDamageable)))
        {
            GameObject damagedObject = coll.gameObject;
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
