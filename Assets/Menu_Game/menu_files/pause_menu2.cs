using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class pause_menu2 : MonoBehaviour {

	public GameObject pauseMenu;

	public void PauseGame()
	{
		Time.timeScale = 0f;
		pauseMenu.SetActive (true);
	}

	public void Resume(string sceneName)
	{
		Time.timeScale = 1f;
		pauseMenu.SetActive (false);
	}

	public void LoadScene (string sceneName)
	{	
		Time.timeScale = 1f;
		SceneManager.LoadScene (sceneName);
	}

	public void StoryMenu (string sceneName)
	{
		Time.timeScale = 1f;
		SceneManager.LoadScene (sceneName);
	}

	public void ChangeToScene (int sceneToChangeTo) 
	{
		if (sceneToChangeTo == 0) {
			Debug.Log("EXIT button have been click");
			Application.Quit ();
		}
		else
		{ 
			Application.LoadLevel (sceneToChangeTo);

		}

	}
}