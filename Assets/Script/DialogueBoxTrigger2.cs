using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DialogueBoxTrigger2 : MonoBehaviour {

	public GameObject textBox;

	public Text theText;

	public TextAsset textfile;
	public string[] textLines;

	public int currentLine;
	public int endAtLine;

	public Player_Control player;

	public bool isActive;

	public bool stopplayermove;

	private bool isTyping = false;
	private bool cancelTyping = false;

	public float typeSpeed;

	// Use this for initialization
	void Start () 
	{
		player = FindObjectOfType<Player_Control> ();

		if(textfile != null)
		{
			textLines = (textfile.text.Split ('\n'));

		}

		if (endAtLine == 0) 
		{
			endAtLine = textLines.Length - 1;
		}

		if (isActive) {
			EnableTextBox ();
		} else 
		{
			DisableTextBox ();
		}


	}

	void Update()
	{
		if (!isActive) {
			return;
		}

		//theText.text = textLines [currentLine];

		if (Input.GetMouseButtonDown (0) || Input.GetKeyDown (KeyCode.G)) 
		{
			if (!isTyping) {
				currentLine += 1;

				if (currentLine > endAtLine) {
					DisableTextBox ();
				} else {
					StartCoroutine (TextScroll (textLines [currentLine]));
				}
			} else if (isTyping && !cancelTyping) {
				cancelTyping = true;
			}

		}
	}

	private IEnumerator TextScroll (string lineOfText)
	{
		int letter = 0;
		theText.text = "";
		isTyping = true;
		cancelTyping = false;
		while (isTyping && !cancelTyping && (letter < lineOfText.Length - 1)) 
		{
			theText.text += lineOfText [letter];
			letter += 1;
			yield return new WaitForSeconds (typeSpeed);
		}
		theText.text = lineOfText;
		isTyping = false;
		cancelTyping = false;
	}
	public void EnableTextBox()
	{
		textBox.SetActive(true);
		isActive = true;

		if (stopplayermove) 
		{
			player.canMove = false;
		}

		StartCoroutine (TextScroll(textLines[currentLine]));

	}

	public void DisableTextBox()
	{
		textBox.SetActive (false);
		isActive = false;

		player.canMove = true;
	}

	public void ReloadScript(TextAsset theText)
	{
		if(theText != null)
		{ 
			textLines = new string[1];
			textLines = (theText.text.Split ('\n'));
		}
	}
}
