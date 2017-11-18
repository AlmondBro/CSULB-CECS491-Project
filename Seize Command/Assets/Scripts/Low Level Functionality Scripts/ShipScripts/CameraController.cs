using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    [SerializeField] GameObject ship;

    private Vector3 offset;

	// Use this for initialization
	void Start () {
        offset = transform.position - ship.transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {
        transform.position = ship.transform.position + offset;
	}
}
