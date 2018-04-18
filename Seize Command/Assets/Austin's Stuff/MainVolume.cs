using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainVolume : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void SetVolume(float value)
	{
		AudioListener.volume = value;
	}
}
