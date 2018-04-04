using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] GameObject shipDeck;

    void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.gameObject.CompareTag("Character"))
        {
            coll.gameObject.transform.parent = shipDeck.transform;
        }
    }
}
