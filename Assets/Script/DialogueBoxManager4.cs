using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DialogueBoxManager4 : MonoBehaviour {

	public GameObject dialgouebox;
	public Text dialoguetext;

	public bool dialogActive;

	public string[] dialoguelines;
	public int currentline;

	private Player_Control theplayer;

	// Use this for initialization
	void Start () {
		theplayer = FindObjectOfType<Player_Control> ();
	}

	// Update is called once per frame
	public void Update () {
		//if (dialogActive && Input.GetKeyDown (KeyCode.Space))
		if (dialogActive && Input.GetMouseButtonDown (0))
		{	
			//use to stop the liness
			//dialgouebox.SetActive (false);
			//dialogActive = false;

			currentline++;
		}

		if (currentline >= dialoguelines.Length) 
		{
			dialgouebox.SetActive (false);
			dialogActive = false;


			//back to line 0
			currentline = 0;
			theplayer.canMove = true;
		}

		dialoguetext.text = dialoguelines [currentline];
	}

	public void ShowBox(string dialogue)
	{
		dialogActive = true;
		dialgouebox.SetActive (true);
		dialoguetext.text = dialogue;
	}

	public void ShowDialogue()
	{
		dialogActive = true;
		dialgouebox.SetActive (true);
		theplayer.canMove = false;
	}
	/*public void dialogueActive()
	{
		if (dialogActive && Input.GetKeyDown (KeyCode.Space))
		{
			dialgouebox.SetActive (false);
			dialogActive = false;
		}
	}*/

}

