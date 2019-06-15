using UnityEngine;
using System.Collections;

public class QuestObject : MonoBehaviour {

	public int questNumber;

	public Quest_Manager thequestmanager;

	public string startText;
	public string endText;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void StartQuest()
	{
		thequestmanager.ShowQuestText (startText);
	}

	public void EndQuest()
	{	
		thequestmanager.ShowQuestText (endText);
		thequestmanager.questCompleted [questNumber] = true;
		gameObject.SetActive (false);
	}
}
