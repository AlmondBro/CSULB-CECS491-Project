using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.Networking.Match;

public class gameChoose : NetworkBehaviour {
	[SerializeField]
	public MatchInfoSnapshot match;
	// Use this for initialization
	void Start () {
		
	}
	
	public void click()
	{
		//Debug.Log(match.name);
		//Debug.Log(match.hostNodeId)
		GameObject nManager = GameObject.FindGameObjectWithTag("nManager");
		nManager.GetComponent<CustomNetworkManager>().targetMatch = match;
	}
	// Update is called once per frame
	void Update () {
		
	}
}
