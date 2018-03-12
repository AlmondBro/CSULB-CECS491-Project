using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_Ship_Movement : MonoBehaviour
{
    Rigidbody2D AI_Ship;
    float timeCounter = 0;
    float size;
    float speed;
    float height;
    void Start()
    {
        AI_Ship = GetComponent<Rigidbody2D>();
        size = 20;
        speed = 2;
        height = 20;

    }

    // Update is called once per frame
    void Update()
    {

        timeCounter += Time.deltaTime * speed;

        float x = Mathf.Cos(timeCounter) * size;
        float y = Mathf.Sin(timeCounter) * height;
        float z = 0;
        AI_Ship.transform.position = new Vector3(x, y, z);
    }
}