using UnityEngine;
using System.Collections;

public class People_Pickup : MonoBehaviour {

	public int pointtoadd3;

	private Sfx_manager sfxMan;

	void Start () 
	{
		sfxMan = FindObjectOfType<Sfx_manager> ();
	}
	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.GetComponent<Player_Control> () == null)
			return;

		People_Manager.AddPoints3(pointtoadd3);

		Destroy (gameObject,3);

		sfxMan.victory.Play ();
	}
}