using UnityEngine;
using System.Collections;

public class splashscreendelayed : MonoBehaviour {
	public float delayTime = 4;

	IEnumerator Start() {
		yield return new WaitForSeconds (delayTime);

		Application.LoadLevel ("menu_dl");
	}
}
