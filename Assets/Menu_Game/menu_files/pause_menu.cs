using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class pause_menu : MonoBehaviour {

	public bool isPaused;

	public GameObject pauseMenuCanvas;

	public void ChangeToScene (int sceneToChangeTo) 
	{
		if (sceneToChangeTo == 0) {
			Debug.Log("EXIT button have been click");
			Application.Quit ();
		}

	}
	
	// Update is called once per frame
	void Update () {

		if (isPaused) 
		{
			pauseMenuCanvas.SetActive (true);
			Time.timeScale = 0f;
		} else {
			pauseMenuCanvas.SetActive (false);
			Time.timeScale = 1f;
		}

		if (Input.GetKeyDown (KeyCode.Return)) 
		{
			isPaused = !isPaused;
		}
	}



	public void Resume(string sceneName)
	{
		isPaused = false;

	}

	public void LoadScene (string sceneName)
	{
		SceneManager.LoadScene (sceneName);
	}




		
}
