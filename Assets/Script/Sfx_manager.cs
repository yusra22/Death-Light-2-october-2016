using UnityEngine;
using System.Collections;

public class Sfx_manager : MonoBehaviour {

	public AudioSource playerhurt;
	public AudioSource keycollected;
	public AudioSource journalcollected;
	public AudioSource areasound;
	public AudioSource areasound2;
	public AudioSource areasound3;
	public AudioSource enemy1;
	public AudioSource staroflife;
	public AudioSource SwordSwing;
	public AudioSource fleshcut;
	public AudioSource teleport;
	public AudioSource victory;
	public AudioSource switchsound;

	private static bool sfxmanExists;

	// Use this for initialization
	void Start () {
		if (!sfxmanExists) 
		{
			sfxmanExists = true;
			DontDestroyOnLoad (transform.gameObject);
		} else {
			//Destroy (gameObject);
		}
	
	}
}
