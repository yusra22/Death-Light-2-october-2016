using UnityEngine;
using System.Collections;

public class endgamescenes : MonoBehaviour {
	
	public float delayTime = 4;

	IEnumerator Start() {
		yield return new WaitForSeconds (delayTime);

		Application.LoadLevel ("story_menu");
	}
}

