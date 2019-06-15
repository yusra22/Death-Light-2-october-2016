using UnityEngine;
using System.Collections;

public class splashscreendelayed2 : MonoBehaviour {

	public float delayTime = 4;

	IEnumerator Start() {
		yield return new WaitForSeconds (delayTime);

		Application.LoadLevel ("splash_dll");
	}
}

