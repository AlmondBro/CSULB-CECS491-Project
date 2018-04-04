using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    [SerializeField] float speed;

    Camera cam;

	// Use this for initialization
	void Start ()
    {
        cam = GetComponent<Camera>();
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.D))
        {
            transform.Translate(-Vector3.right * speed * Time.deltaTime);
        }
	}
}
