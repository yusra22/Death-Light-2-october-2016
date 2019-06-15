using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UImanager : MonoBehaviour {

	public Slider healthstatus;
	public Text hptext;
	public playerhealthmanager playerhp;

	private bool uiExists;

	// Use this for initialization
	void Start () {
		
		if (!uiExists) {
			uiExists = true;
			DontDestroyOnLoad (transform.gameObject);
		} else {
			Destroy (gameObject);
		}

	}
	
	// Update is called once per frame
	void Update () {
		healthstatus.maxValue = playerhp.playermaxhealth;
		healthstatus.value = playerhp.playercurrenthealth;
		hptext.text = "HP: " + playerhp.playercurrenthealth + "/" + playerhp.playermaxhealth;
	
	}
}
