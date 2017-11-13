using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotgunScript : MonoBehaviour {

    Rigidbody2D rb2d;

    void Start()
    {

        rb2d = GetComponent<Rigidbody2D>();
        StartCoroutine(deactivate());

    }

    private IEnumerator deactivate()
    {
        rb2d.velocity = transform.up * 10;
        yield return new WaitForSecondsRealtime(1);
        Destroy(gameObject);
    }

}
