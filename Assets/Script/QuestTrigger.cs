using UnityEngine;
using System.Collections;

public class QuestTrigger : MonoBehaviour {

	private Quest_Manager theQM;

	public int questNumber;

	public bool startquest;
	public bool endquest;

	// Use this for initialization
	void Start () {
		theQM = FindObjectOfType<Quest_Manager> ();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.name == "Player") 
		{
			if (!theQM.questCompleted[questNumber]) 
			{
				if (startquest && !theQM.quests [questNumber].gameObject.activeSelf) 
				{
					theQM.quests[questNumber].gameObject.SetActive (true);
					theQM.quests [questNumber].StartQuest ();
				}

				if (endquest && !theQM.quests [questNumber].gameObject.activeSelf) 
				{
					theQM.quests [questNumber].EndQuest ();
				}

			}
		}
	}
}
