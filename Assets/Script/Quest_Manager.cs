using UnityEngine;
using System.Collections;

public class Quest_Manager : MonoBehaviour {

	public QuestObject[] quests;
	public bool[] questCompleted;

	public DialogueBoxManager4 theDM;

	// Use this for initialization
	void Start () 
	{
		questCompleted = new bool[quests.Length];

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void ShowQuestText (string questText)
	{
		theDM.dialoguelines = new string[1];
		theDM.dialoguelines[0] = questText;

		theDM.currentline = 0;
		theDM.ShowDialogue ();

		/*theDM.textLines = new string[1];
		theDM.textLines [0] = questText;

		theDM.currentLine = 0;*/
	}
}
