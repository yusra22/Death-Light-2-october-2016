using UnityEngine;
using System.Collections;

public class TrapPlayer : MonoBehaviour {

	public Level_Manager levelmanager;
	public int damagetoLose;

	// Use this for initialization
	void Start () {
		levelmanager = FindObjectOfType<Level_Manager> ();

	}

	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.name == "Player") 
		{	
			levelmanager.RespawnPlayer ();
			other.gameObject.GetComponent<playerhealthmanager> ().KillPlayer (damagetoLose);
		} 
	}
}
