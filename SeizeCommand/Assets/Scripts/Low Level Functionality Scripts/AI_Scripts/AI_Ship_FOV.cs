
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
public class AI_Ship_FOV : MonoBehaviour {


	protected List<GameObject> targets = new List<GameObject>();
	GameObject selected_target;

	AI_Patrol_Movement apm;

	void Start()
	{
		apm = gameObject.GetComponentInParent<AI_Patrol_Movement> ();
		selected_target = null; // initially we have no selected
	}

	void Update () {

		int index = FindNearestTarget();
		if (index != -1) {
			selected_target = targets [index];
		} else {
			//index == -1
			selected_target = null;
		}

	}

	public int FindNearestTarget()
	{
		int index = -1; //not in targets
		if (targets.Count > 0) {
			float minDistance = Mathf.Infinity;
			for (int i=0; i < targets.Count; i++) {
				if (targets [i] == null) {
					targets.RemoveAt (i);
				} else {
					float distance = Vector3.Distance (targets [i].transform.position, transform.position);
					if (distance < minDistance) {
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
		
		if (collision.gameObject.CompareTag("Player") || collision.gameObject.CompareTag("Ship")){
			targets.Add(collision.gameObject);
		}
		if (collision.gameObject.CompareTag ("Projectile")) {
			Vector3 fromPosition = collision.gameObject.transform.position;
			Vector3 toPosition = transform.position;
			//Vector3 direction = toPosition - fromPosition;
	
			RaycastHit2D hit = Physics2D.Linecast (fromPosition, toPosition);
			if (hit != null && hit.collider != null) {

				if( !hit.transform.CompareTag("AI_Ship_Projectile"))
				{
					apm.StopPatrol ();
					apm.SetDodging ();
				}

			}
		}

	
	}

	void OnTriggerExit2D(Collider2D collision)
	{
		if (collision.gameObject.CompareTag("Player") || collision.gameObject.CompareTag("Ship"))
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

*/