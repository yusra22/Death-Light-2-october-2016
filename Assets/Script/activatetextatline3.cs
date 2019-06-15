﻿using UnityEngine;
using System.Collections;

public class activatetextatline3 : MonoBehaviour {

	public TextAsset theText;

	public int startLine;
	public int endLine;

	public DialogueBoxTrigger3 theTextBox;

	public bool requirebuttonpress;
	private bool waitforpress;

	public bool destroywhenactivated;

	// Use this for initialization
	void Start () {
		theTextBox = FindObjectOfType<DialogueBoxTrigger3> ();

	}

	// Update is called once per frame
	void Update () {

		if (waitforpress && Input.GetMouseButtonDown (0)) {
			theTextBox.ReloadScript (theText);
			theTextBox.currentLine = startLine;
			theTextBox.endAtLine = endLine;
			theTextBox.EnableTextBox ();

			if (destroywhenactivated) {
				Destroy (gameObject);
			}

		}
	}
	void OnTriggerEnter2D (Collider2D other)
	{
		if (requirebuttonpress) 
		{
			waitforpress = true;
			return;
		}
		if (other.name == "Player") {
			theTextBox.ReloadScript (theText);
			theTextBox.currentLine = startLine;
			theTextBox.endAtLine = endLine;
			theTextBox.EnableTextBox ();

			if (destroywhenactivated) 
			{
				Destroy (gameObject);
			}
		}
	}

	void OnTriggerExit2D(Collider2D other)
	{
		if (other.name == "Player") 
		{
			waitforpress = false;
		}
	}
}

