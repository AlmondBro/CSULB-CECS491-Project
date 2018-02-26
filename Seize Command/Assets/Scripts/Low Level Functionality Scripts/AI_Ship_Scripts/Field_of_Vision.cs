using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Field_of_Vision : MonoBehaviour {

    public GameObject target;

    public Field_of_Vision()
    {

    }

    void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Target In Bound");
            target = collision.gameObject;
        }

    }

    public GameObject addNewTarget()
    {
        return target;
    }

}
