using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{

    private Rigidbody2D rb2d;
    public double hull = 10;

    void Start()
    {

        rb2d = GetComponent<Rigidbody2D>();
        rb2d.AddForce(transform.up * 10);

    }

    private void Update()
    {
        if(hull <= 0)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Cannon")
        {
            hull -= 1;
            Destroy(other.gameObject);
        }
        if (other.tag == "Shotgun")
        {
            hull -= 1;
            Destroy(other.gameObject);
        }
        if (other.tag == "Disruptor")
        {
            StartCoroutine(stop());
            Destroy(other.gameObject);
        }
        if (other.tag == "Missile")
        {
            hull -= 1;
            Destroy(other.gameObject);
        }
        if (other.tag == "Torpedo")
        {
            hull -= 1;
            Destroy(other.gameObject);
        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Beam")
        {
            hull -= 0.1;
        }
    }

    private IEnumerator stop()
    {
        rb2d.velocity = new Vector2(0, 0);
        yield return new WaitForSecondsRealtime(5);
        rb2d.AddForce(transform.up * 10);
    }
}
