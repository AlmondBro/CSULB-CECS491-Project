using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    [SerializeField] GameObject ship;

    Vector3 offset;

	void Start ()
    {
        offset = transform.position - ship.transform.position;
	}
	
	void LateUpdate ()
    {
        transform.position = ship.transform.position + offset;
	}
}
