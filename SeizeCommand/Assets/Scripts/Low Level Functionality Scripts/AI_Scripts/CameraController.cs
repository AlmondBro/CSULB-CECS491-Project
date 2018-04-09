using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    Vector3 offset;

	void Start ()
    {
        offset = transform.position - PlayerReference.p.transform.position;
	}
	
	void LateUpdate ()
    {
        if(PlayerReference.p)
        {
            transform.position = PlayerReference.p.transform.position + offset;
        }
	}
}
