using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_Patrol_Movement : MonoBehaviour {
	Rigidbody2D AI_Ship;
	float timeCounter = 0;
	float size; 
	float height;
	bool patrol;

	void Start () {
		AI_Ship = GetComponent<Rigidbody2D>();
		size = 20;
		height = 20;
		patrol = true;

	}

	void FixedUpdate(){
		if (patrol) {
			Patrol ();
		}
	}

	void Patrol () {
		
		timeCounter += Time.deltaTime;

		float x = Mathf.Cos (timeCounter) * size;
		float y = Mathf.Sin (timeCounter) *height;
		float z = 0;
		AI_Ship.transform.position = new Vector3 (x, y, z);
	}

	public void SetPatrol()
	{
		patrol = true;
	}
	public void StopPatrol()
	{
		patrol = false;
	}
}
