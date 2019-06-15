using UnityEngine;
using System.Collections;

public class Level_Manager : MonoBehaviour {

	public GameObject startpoint;

	private Player_Control player;


	// Use this for initialization
	void Start () {
		player = FindObjectOfType<Player_Control> ();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void RespawnPlayer()
	{
		Debug.Log ("Player Reborn");
		player.transform.position = startpoint.transform.position;
	}
}
