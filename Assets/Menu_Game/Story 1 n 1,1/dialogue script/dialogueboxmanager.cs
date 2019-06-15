 using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class dialogueboxmanager : MonoBehaviour {

	public GameObject textBox;

	public Text theText;

	public TextAsset textfile;
	public string[] textLines;

	public int currentLine;
	public int endAtLine;

	private bool isTyping = false;
	private bool cancelTyping = false;

	public float typeSpeed;

	// Use this for initialization
	void Start () 
	{

		if(textfile != null)
		{
			textLines = (textfile.text.Split ('\n'));

		}

		if (endAtLine == 0) 
		{
			endAtLine = textLines.Length - 1;
		}
			
	}

	void Update()
	{
		//theText.text = textLines [currentLine];

		if (Input.GetMouseButtonDown (0)) {	
			if (!isTyping) {
				
				currentLine += 1;

				if (currentLine > endAtLine) {
					textBox.SetActive (false);
					Destroy (gameObject);
				} 
				else 
				{
					StartCoroutine (TextScroll(textLines[currentLine]));
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
}