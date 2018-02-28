using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_Ship_FieldofView : MonoBehaviour {

    protected List<GameObject> targets = new List<GameObject>();
    public GameObject selected_target;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(targets.Count != 0)
        {
            if(targets[0] == null)
            {
                targets.Remove(targets[0]);
            }
            if(targets.Count != 0)
            {
                selected_target = targets[0];
                /*
                Vector3 playerDistance = selected_target.transform.position - transform.position;
                float angle = (Mathf.Atan2(playerDistance.y, playerDistance.x) * Mathf.Rad2Deg) - 90;
                Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);*/
            }
        }
	}

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player")){
            targets.Add(collision.gameObject);
            Debug.Log(targets[0]);
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            targets.Remove(collision.gameObject);
        }
    }

    public GameObject GetTarget()
    {
        if(selected_target != null)
        {
            return selected_target;
        }
        return null;
    }
}
