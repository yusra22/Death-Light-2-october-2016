using UnityEngine;
using System.Collections;

public class Journal_Pickup : MonoBehaviour {

	public int pointtoadd1;

	private Sfx_manager sfxMan;

	void Start () 
	{
		sfxMan = FindObjectOfType<Sfx_manager> ();
	}
	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.GetComponent<Player_Control> () == null)
			return;

		JournalCollect_Manager.AddPoints1 (pointtoadd1);

		Destroy (gameObject);

		sfxMan.journalcollected.Play ();
	}

}
