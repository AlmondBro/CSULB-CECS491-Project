using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_Ship_Dodge : MonoBehaviour {

    float rot_speed = 20f;
    float ship_speed = 2f;
    Vector3 dest;
    bool dodge;
    Rigidbody2D AI_Ship;

    float x, y;

    float dir, set_dir;

    void Start()
    {
        AI_Ship = GetComponent<Rigidbody2D>();
        dir = Random.Range(1, 3);

        if(dir == 1)
        {
            set_dir = 1;
        }
        else
        {
            set_dir = -1;
        }
        dodge = false;
    }

    private void FixedUpdate()
    {
        if (dodge)
        {
            Dodge();
        }
    }

    void Dodge()
    {
        transform.position = transform.up * ship_speed;
        if(set_dir == 1)
        {
            transform.Rotate(Vector3.forward * rot_speed);
        }
        else
        {
            transform.Rotate(Vector3.forward * -rot_speed);
        }
    }

    public void SetDodge()
    {
        dodge = true;
    }

    public void StopDodge()
    {
        dodge = false;
    }
}
