using UnityEngine;
using System.Collections;

public class exitctrl : MonoBehaviour {
	
	void Update ()
	{
		if (Input.GetKey(KeyCode.Escape))
		{
			if (Application.platform == RuntimePlatform.Android)
			{
				Application.Quit();

				return;
			}
		}
	}
}