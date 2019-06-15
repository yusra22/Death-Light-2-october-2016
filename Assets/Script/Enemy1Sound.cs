using UnityEngine;
using System.Collections;

public class Enemy1Sound : MonoBehaviour 
{

	private Sfx_manager sfxMan;

	// Use this for initialization
	void Start () 
	{
		sfxMan = FindObjectOfType<Sfx_manager> ();
	}

	// Update is called once per frame
	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.GetComponent<Player_Control> () == null)
			return;
		sfxMan.enemy1.Play ();
	}
}