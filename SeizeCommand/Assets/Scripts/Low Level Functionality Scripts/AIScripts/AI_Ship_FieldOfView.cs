using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_Ship_FieldOfView : MonoBehaviour {


	protected List<GameObject> targets = new List<GameObject>();
	GameObject selected_target;





	// Update is called once per frame
	void Update () {
		
		if (targets.Count != 0) {
			selected_target = targets [0];
			if (selected_target == null) {
				targets.Remove (targets [0]);
			}
		} else {
			selected_target = null;
		}
	}

	void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.CompareTag("Player")){
			targets.Add(collision.gameObject);
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