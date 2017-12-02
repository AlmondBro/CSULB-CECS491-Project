using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponAimManager : AbstractAimManager
{
    void Start()
    {
        enabled = false;
    }

    void FixedUpdate()
    {
        Aim();
    }

    protected override void Aim()
    {
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        difference.Normalize();
        float rotation_z = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.parent.rotation = Quaternion.Euler(0f, 0f, rotation_z + -90);
    }
}
