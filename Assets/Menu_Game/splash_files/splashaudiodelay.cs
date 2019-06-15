using UnityEngine;
using System.Collections;

public class splashaudiodelay : MonoBehaviour {

	public AudioSource dyy;

	void  Update (){

		if (!dyy.isPlaying && Time.time >= 2.45) {
			dyy.Play();
		}
	}
}
