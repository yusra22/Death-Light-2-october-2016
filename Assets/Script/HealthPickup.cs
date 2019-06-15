using UnityEngine;
using System.Collections;

public class HealthPickup : MonoBehaviour {

	public int healthtogive;
	private Sfx_manager sfxMan;

	void Start () 
	{
		sfxMan = FindObjectOfType<Sfx_manager> ();
	}
		
	// Use this for initialization
	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.GetComponent<Player_Control> () == null)
			return;
		
		other.gameObject.GetComponent<playerhealthmanager> ().KillPlayer (-healthtogive);

		Destroy (gameObject);

		sfxMan.staroflife.Play ();

	}

}
