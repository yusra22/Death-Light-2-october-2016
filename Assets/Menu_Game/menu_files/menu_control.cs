using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class menu_control : MonoBehaviour 
{
	public void LoadScene (string sceneName)
	{
		SceneManager.LoadScene (sceneName);
		Debug.Log("'NEW GAME' button has been clicked");

	}
}
