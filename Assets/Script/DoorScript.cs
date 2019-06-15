﻿using UnityEngine;
using System.Collections;

public class DoorScript : MonoBehaviour {
	Animator anim;

	// Use this for initialization
	void Start () {
		anim = GetComponent <Animator > ();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
		
	public void DoorClose()
	{
		anim.SetBool ("Opens", false);
	}

	public void DoorOpen()
	{
		anim.SetBool ("Opens", true);
	}
}

