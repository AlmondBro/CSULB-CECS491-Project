using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_MoveTowards_Movement : MonoBehaviour {

    GameObject target;

    Vector3 distance;
    float speed = 30f;
    float rot_speed = 57f;
    bool move;

    void Start()
    {
        move = false;
    }

    public void SetTarget(GameObject target)
    {
        this.target = target;
        distance = target.transform.position - transform.position;
        distance.Normalize();
    }

    void Update()
    {
        if (move)
        {
            MoveTowards();
        }
    }

    void MoveTowards()
    {
        if (target != null)
        {
            float calc = Mathf.Sqrt(Mathf.Pow(distance.x, 2) + Mathf.Pow(distance.y, 2));
            if (calc >= 100)
            {

            }
            else if (calc < 100 && calc >= 50)
            {
                float rotation_z = Mathf.Atan2(distance.y, distance.x) * Mathf.Rad2Deg;

                Quaternion rot = Quaternion.Euler(0f, 0f, rotation_z + -90);

                transform.rotation = Quaternion.RotateTowards(transform.rotation, rot, rot_speed * Time.deltaTime);

                transform.position = Vector3.MoveTowards(transform.position, distance, speed * Time.deltaTime);
            }
        }
    }

    public void SetMove()
    {
        move = true;
    }

    public void StopMove()
    {
        move = false;
    }
}
