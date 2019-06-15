using UnityEngine;
using System.Collections;

public class SwitchScriptLevel : MonoBehaviour {
	public DoorTrigger[] doorTrig;
	Animator anim;
	public bool sticks;

	// Use this for initialization
	void Start () {
		anim = GetComponent <Animator > ();
	
	}   
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerStay2D()
	{
		anim.SetBool ("GoDown", true);

		foreach (DoorTrigger trigger in doorTrig) {
			trigger.Toggle (true);
		}
	}

	void OnTriggerExit2D()
	{
		if (sticks)
			return;
		anim.SetBool ("GoDown", false);
		foreach (DoorTrigger trigger in doorTrig) {
			trigger.Toggle (false );
		}
	}


}
