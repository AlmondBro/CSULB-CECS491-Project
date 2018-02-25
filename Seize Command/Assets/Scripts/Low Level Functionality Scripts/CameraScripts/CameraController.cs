using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class CameraController : MonoBehaviour
{
    Vector3 offset;

	public GameObject player;

	void Start ()
    {

	}
	
	void LateUpdate ()
    {
		if(player)
        {
			transform.position = player.transform.position + offset;
        }
	}

	public void lockToPlayer(GameObject p)
	{
		player = p;
		offset = new Vector3 (0, 0, -10);
	}
		
}
