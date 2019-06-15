using UnityEngine;
using System.Collections;

public class Collect_Pickup : MonoBehaviour {

	public int pointtoadd;

	private Sfx_manager sfxMan;

	void Start () 
	{
		sfxMan = FindObjectOfType<Sfx_manager> ();
	}
	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.GetComponent<Player_Control> () == null)
			return;

		Collect_Manager.AddPoints(pointtoadd);

		Destroy (gameObject);

		sfxMan.keycollected.Play ();
	}
			
}
