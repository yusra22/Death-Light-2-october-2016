using UnityEngine;
using System.Collections;

public class exitctrl_button : MonoBehaviour {

	public void ChangeToScene (int sceneToChangeTo) {
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
