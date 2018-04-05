using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_Aim_Manager : AbstractAimManager
{
<<<<<<< HEAD
    private float rot_speed = 30;
    Vector3 distance;
    float speed = 30f;
    float rotation_speed = 57f;
    AI_Ship_FieldOfVision fov;
=======
    [SerializeField] float rot_speed;

    AI_Ship_TargetSelection targetSelector;

    void Start()
    {
        targetSelector = transform.root.GetComponent<AI_Ship_TargetSelection>();
    }

    void Update()
    {
        Aim();    
    }

    protected override void Aim()
    {
        GameObject target = targetSelector.ClosestTarget;

        if(target)
        {
            Vector3 distance = target.transform.position - transform.position;
            distance.Normalize();
            float rotation_z = Mathf.Atan2(distance.y, distance.x) * Mathf.Rad2Deg;
            Quaternion rot = Quaternion.Euler(0f, 0f, rotation_z + -90);

            transform.rotation = Quaternion.RotateTowards(transform.rotation, rot, rot_speed * Time.deltaTime);
        }
    }

    /*
    [SerializeField] float rot_speed;
    AI_Ship_TargetSelection targetSelector;
>>>>>>> 355bda87c535a27f36a2804d5fae805d3b3f76cf
    float attackTime = 3;
    float currentTime = 0;
    protected GameObject target;
    AI_Patrol_Movement apm;
    Rigidbody2D ship;
    bool dodging;
    float moveDelay = 3f;
    void Start()
    {

        fov = gameObject.GetComponentInParent<AI_Ship_FieldOfVision>();
        apm = gameObject.GetComponentInParent<AI_Patrol_Movement>();
        dodging = apm.isDodging();

    }

    // Update is called once per frame
    void Update()
    {

        Aim();
    }

    void Aim()
    {
        target = fov.GetTarget();
        dodging = apm.isDodging();
        if (target != null && !dodging)
        {
            //Stop patrolling
            apm.StopPatrol();

            //Calculate distance between target and cannon
            Vector3 distance = target.transform.position - transform.position;

            if (Vector3.Distance(target.transform.position, transform.position) > 40)
            {
                MoveTowards();
            }
            distance.Normalize();

            float rotation_z = Mathf.Atan2(distance.y, distance.x) * Mathf.Rad2Deg;

            Quaternion rot = Quaternion.Euler(0f, 0f, rotation_z + -90);

            transform.rotation = Quaternion.RotateTowards(transform.rotation, rot, rot_speed * Time.deltaTime);
            currentTime += Time.deltaTime;
            if (currentTime >= attackTime)
            {

                Ship_Attack();
                currentTime = 0; //reset
            }
        }
        else
        {
            apm.SetPatrol(); //target is "empty" or dead, begin patrolling
        }

    }
<<<<<<< HEAD
    void MoveTowards()
    {
        if (moveDelay == 3)
        {
            ship = apm.getShip();

            distance = target.transform.position - ship.transform.position;

            float rotation_z = Mathf.Atan2(distance.y, distance.x) * Mathf.Rad2Deg;

            Quaternion rot = Quaternion.Euler(0f, 0f, rotation_z + -90);

            ship.transform.rotation = Quaternion.RotateTowards(transform.rotation, rot, rotation_speed * Time.deltaTime);

            ship.transform.position = Vector3.MoveTowards(transform.position, distance, speed * Time.deltaTime);
        }
        moveDelay -= Time.deltaTime;
        if (moveDelay <= 0)
        {
            moveDelay = 3;
        }
    }
}
=======

    */
}
>>>>>>> 355bda87c535a27f36a2804d5fae805d3b3f76cf
