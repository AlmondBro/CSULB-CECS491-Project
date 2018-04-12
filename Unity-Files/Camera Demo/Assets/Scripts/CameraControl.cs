using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {

    float delta;
    public Camera self;

	void Start () {
		
	}
	
	void FixedUpdate () {

        delta = Input.GetAxis("Mouse ScrollWheel");
        if(delta > 0f)
        {
            self.orthographicSize--;
        }
        if(delta < 0f)
        {
            self.orthographicSize++;
        }

	}
}
