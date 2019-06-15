using UnityEngine;
using System.Collections;

public class KillPlayer : MonoBehaviour {

	public int damagetoLose;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.name == "Player") 
		{
			other.gameObject.GetComponent<playerhealthmanager> ().KillPlayer (damagetoLose);

		} 
	}
}
