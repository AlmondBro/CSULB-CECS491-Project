using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public abstract class AbstractProjectile : MonoBehaviour
{
    [SerializeField] protected float projectileDamage;
    protected Rigidbody2D rb;

    [SerializeField] float lifeTime;

    protected virtual void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        StartCoroutine(CoDestroyOverTime());
    }

    protected abstract void SendDamage(GameObject ship);

    IEnumerator CoDestroyOverTime()
    {
        yield return new WaitForSeconds(lifeTime);
        Destroy(gameObject);
    }
}
