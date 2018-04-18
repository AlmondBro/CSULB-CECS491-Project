using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour {

    public Transform target;
    float speed = 5;

    Vector3[] path;
    int targetIndex;

    Vector3 distance;
    float rot_speed = 250f;

    void Start()
    {
        PathRequestManager.RequestPath(transform.position, target.position, OnPathFound);
    }

    public void OnPathFound(Vector3[] newPath, bool pathSuccess)
    {
        if (pathSuccess)
        {
            path = newPath;
            StopCoroutine("FollowPath");
            StartCoroutine("FollowPath");
        }
    }

    IEnumerator FollowPath()
    {
        Vector3 currentWayPoint = path[0];

        while (true)
        {
            if(transform.position == currentWayPoint)
            {
                targetIndex++; 
                if(targetIndex >= path.Length)
                {
                    yield break;
                }
                currentWayPoint = path[targetIndex];
            }

            distance = currentWayPoint - transform.position;
            distance.Normalize();

            float rotation_z = Mathf.Atan2(distance.y, distance.x) * Mathf.Rad2Deg;

            Quaternion rot = Quaternion.Euler(0f, 0f, rotation_z + -90);

            transform.rotation = Quaternion.RotateTowards(transform.rotation, rot, rot_speed * Time.deltaTime);

            transform.position = Vector3.MoveTowards(transform.position, currentWayPoint, speed * Time.deltaTime);

            yield return null;
        }
    }

    public void OnDrawGizmos()
    {
        if(path != null)
        {
            for(int i = targetIndex; i < path.Length; i++)
            {
                Gizmos.color = Color.black;
                Gizmos.DrawCube(path[i], Vector3.one);

                if(i == targetIndex)
                {
                    Gizmos.DrawLine(transform.position, path[i]);
                }
                else
                {
                    Gizmos.DrawLine(path[i - 1], path[i]);
                }
            }
        }
    }
}
