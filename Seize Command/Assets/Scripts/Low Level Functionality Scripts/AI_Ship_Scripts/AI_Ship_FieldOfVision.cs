using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_Ship_FieldOfVision : MonoBehaviour
{


    protected List<GameObject> targets = new List<GameObject>();
    GameObject selected_target;

    AI_Patrol_Movement apm;

    void Start()
    {
        apm = gameObject.GetComponentInParent<AI_Patrol_Movement>();
        selected_target = null; // initially we have no selected
    }

    void Update()
    {

        int index = FindNearestTarget();
        if (index != -1)
        {
            selected_target = targets[index];
        }
        else
        {
            //index == -1
            selected_target = null;
        }

    }

    public int FindNearestTarget()
    {
        int index = -1; //not in targets
        if (targets.Count > 0)
        {
            float minDistance = Mathf.Infinity;
            for (int i = 0; i < targets.Count; i++)
            {
                if (targets[i] == null)
                {
                    targets.RemoveAt(i);
                }
                else
                {
                    float distance = Vector3.Distance(targets[i].transform.position, transform.position);
                    if (distance < minDistance)
                    {
                        index = i;
                        minDistance = distance; //update our minDistance
                    }
                }
            }
        }
        return index;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {
            targets.Add(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("Projectile"))
        {

            //Check if projectile is coming towards me
            int RaysToShoot = 10;

            float angle = 0;
            for (int i = 0; i < RaysToShoot; i++)
            {
                float x = Mathf.Sin(angle);
                float y = Mathf.Cos(angle);
                angle += 2 * Mathf.PI / RaysToShoot;

                Vector3 dir = new Vector3(transform.position.x + x, transform.position.y + y, 0);
                RaycastHit hit;
                Debug.DrawLine (transform.position, dir, Color.red);
                //If it is, attempt to dodge
                if (Physics.Raycast(transform.position, dir, out hit))
                {
                    apm.StopPatrol();
                    apm.SetDodging();
                }
            }
        }

    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            int index = targets.IndexOf(collision.gameObject);
            targets.RemoveAt(index);

        }
    }

    public GameObject GetTarget()
    {
        return selected_target;
    }
}
