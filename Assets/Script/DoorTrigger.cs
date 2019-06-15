using UnityEngine;
using System.Collections;

public class DoorTrigger : MonoBehaviour {
	public DoorScript door;

	public bool ignoreTrigger;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other){
		if (ignoreTrigger)
			return;
		if (other.gameObject.name == "Player")
			door.DoorClose ();
	}

	void OnTriggerExit2D(Collider2D other){
		if (ignoreTrigger)
			return;
		if (other.gameObject.name == "Player")
			door.DoorOpen ();
	}

	public void Toggle(bool state)
	{
		if (state)
			door.DoorOpen ();
		else
			door.DoorClose ();
	
}
}