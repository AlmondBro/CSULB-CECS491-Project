using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_Patrol_Movement : MonoBehaviour
{
    Rigidbody2D AI_Ship;
    float timeCounter = 0;
    float size;
    float height;
    bool patrol;

    float rotation_speed = 57f;

    float x_position;
    float y_position;

    void Start()
    {
        AI_Ship = GetComponent<Rigidbody2D>();
        size = 50;
        height = 50;
        patrol = true;

        x_position = transform.position.x;
        y_position = transform.position.y;
    }

    void FixedUpdate()
    {
        if (patrol)
        {
            Patrol();
        }
    }

    void Patrol()
    {
        
        timeCounter += Time.deltaTime;

        float x = Mathf.Cos(timeCounter) * size;
        float y = Mathf.Sin(timeCounter) * height;
        float z = 0;
        AI_Ship.transform.position = new Vector3(x+x_position, y+y_position, z);

        transform.Rotate(Vector3.forward * rotation_speed * Time.deltaTime);
    }

    public void SetPatrol()
    {
        patrol = true;
    }
    public void StopPatrol()
    {
        patrol = false;
    }
}