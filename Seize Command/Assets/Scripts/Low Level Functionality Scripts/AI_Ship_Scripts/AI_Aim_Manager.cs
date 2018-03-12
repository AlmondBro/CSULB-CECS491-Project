using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_Aim_Manager : AI_Ship_Attack
{
    private float rot_speed = 30;
    AI_Ship_FieldOfVision fov;
    float attackTime = 3;
    float currentTime = 0;
    protected GameObject target;
    AI_Patrol_Movement apm;

    void Start()
    {
        fov = gameObject.GetComponentInParent<AI_Ship_FieldOfVision>();
        apm = gameObject.GetComponentInParent<AI_Patrol_Movement>();

    }

    // Update is called once per frame
    void Update()
    {

        Aim();
    }

    void Aim()
    {
        target = fov.GetTarget();
        if (target != null)
        {
            //Stop patrolling
            apm.StopPatrol();

            //Calculate distance between target and cannon
            Vector3 distance = target.transform.position - transform.position;
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
}