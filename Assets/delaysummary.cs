using UnityEngine;
using System.Collections;

public class delaysummary : MonoBehaviour {

	public float delayTime = 4;

	IEnumerator Start() {
		yield return new WaitForSeconds (delayTime);

		Application.LoadLevel ("credit");
	}
}
