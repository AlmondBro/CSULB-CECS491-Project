using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseAudio : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		/*if (PauseMenu.GameIsPaused) {
			GetComponent<AudioSource> ().pitch = .5f;
		} else {
			GetComponent<AudioSource> ().pitch = 1f;
		}*/
	}
	public void SetVolume(float value)
	{
		GetComponent<AudioSource> ().pitch = value;
		Debug.Log (value);
	}
}
