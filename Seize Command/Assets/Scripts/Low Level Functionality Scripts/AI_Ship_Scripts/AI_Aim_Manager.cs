using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_Aim_Manager : MonoBehaviour{
    private float rot_speed = 30;
    AI_Ship_FieldofView fov;
    protected GameObject target;

    void Start()
    {
        fov = gameObject.AddComponent(typeof(AI_Ship_FieldofView)) as AI_Ship_FieldofView;
    }

    // Update is called once per frame
    void Update () {
        Aim();
	}

    void Aim()
    {
        target = fov.GetTarget();
        if(target != null)
        {
            Debug.Log(target);
            Vector3 distance = target.transform.position - transform.position;
            distance.Normalize();
            float rotation_z = Mathf.Atan2(distance.y, distance.x) * Mathf.Rad2Deg;
            Quaternion rot = Quaternion.Euler(0f, 0f, rotation_z + -90);

            transform.rotation = Quaternion.RotateTowards(transform.rotation, rot, rot_speed * Time.deltaTime);
        }
    }
}
