using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipAimManager : AbstractAimManager
{
    [SerializeField] float rotation_speed;

    protected override void Aim()
    {
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        difference.Normalize();
        float rotation_z = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        Quaternion rot = Quaternion.Euler(0f, 0f, rotation_z + -90);

        transform.rotation = Quaternion.RotateTowards(transform.rotation, rot, rotation_speed * Time.deltaTime);
    }
}
