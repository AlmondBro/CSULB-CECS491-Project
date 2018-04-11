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
    bool dodging;

    float rotation_speed = 57f;

    float rot_speed = 20f;
    float ship_speed = 2f;
    Vector3 dest;
    float x_position;
    float y_position;

    //set up our components:
    void Start()
    {
        AI_Ship = gameObject.GetComponentInParent<Rigidbody2D>();
        size = 50;
        height = 50;
        patrol = true; //start patrolling
        dodging = false; //dodge is turned on when patrol is off

        x_position = transform.position.x;
        y_position = transform.position.y;

    }


    void FixedUpdate()
    {

        if (patrol)
        {
            Patrol();
        }
        if (dodging)
        {
            Dodge();
        }

        Patrol();

    }

    void Patrol()
    {

        timeCounter += Time.deltaTime;

        float x = Mathf.Cos(timeCounter) * size;
        float y = Mathf.Sin(timeCounter) * height;
        float z = 0;
        AI_Ship.transform.position = new Vector3(x + x_position, y + y_position, z);

        transform.Rotate(Vector3.forward * rotation_speed * Time.deltaTime);
    }

    void Dodge()
    {

        transform.position = transform.up * ship_speed;
        transform.Rotate(Vector3.forward * rot_speed);
        //done dodging
        StopDodging();
        SetPatrol();

    }
    public void SetPatrol()
    {
        patrol = true;
    }
    public void StopPatrol()
    {
        patrol = false;
    }

    public void SetDodging()
    {
        dodging = true;
    }
    public void StopDodging()
    {
        dodging = false;
    }
    public bool isDodging()
    {
        return dodging;
    }
    public Rigidbody2D getShip()
    {
        return AI_Ship;
    }
}


