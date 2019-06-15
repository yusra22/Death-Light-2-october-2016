using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DialogueHolder : MonoBehaviour {

	public string dialogue;
	private DialogueBoxManager4 dMan;

	public string [] dialoguelines;


	// Use this for initialization
	void Start () {
		dMan = FindObjectOfType<DialogueBoxManager4> ();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnTriggerStay2D (Collider2D other)
	{
		if(other.gameObject.name == "Player")
		{
			if(Input.GetMouseButtonUp (0))
			//if(Input.GetKeyUp(KeyCode.Space))
				{
					//dMan.ShowBox(dialogue);

					if (!dMan.dialogActive) 
					{
					dMan.dialoguelines = dialoguelines;
					dMan.currentline = 0;
					dMan.ShowDialogue ();
					}
				
				}
		}
	}
}
