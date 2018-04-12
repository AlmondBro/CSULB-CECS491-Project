using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

	public static bool GameIsPaused = false;

	public GameObject pauseMenuUI;
	public GameObject audioPanel;
	public GameObject mainMenuPanel;
	public GameObject particles;
	public GameObject fadePanel;
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			if (GameIsPaused)
			{
				Resume();
			}
			else
			{
				Pause();
			}
		}
	}

	public void Resume()
	{
		mainMenuPanel.SetActive(false);
		audioPanel.SetActive(false);
		pauseMenuUI.SetActive(false);
		particles.SetActive(false);
		fadePanel.SetActive(false);
		Time.timeScale = 1f;
		GameIsPaused = false;
	}

	void Pause()
	{
		pauseMenuUI.SetActive(true);
		particles.SetActive(true);
		fadePanel.SetActive(true);
		Time.timeScale = 0f;
		GameIsPaused = true;
	}

	public void LoadVolume()
	{
		mainMenuPanel.SetActive(false);
		pauseMenuUI.SetActive(false);

		audioPanel.SetActive(true);
	}

	public void LoadMenu()
	{
		//Time.timeScale = 1f;
		//Debug.Log("Loading Menu...");
		//SceneManager.LoadScene("Menu");

		pauseMenuUI.SetActive(false);
		audioPanel.SetActive(false);
		mainMenuPanel.SetActive(true);
	}

	public void QuitGame()
	{
		Debug.Log("Quitting game...");
		Application.Quit();
	}

	public void GoBack()
	{
		audioPanel.SetActive(false);
		mainMenuPanel.SetActive(false);

		pauseMenuUI.SetActive(true);
	}
}
