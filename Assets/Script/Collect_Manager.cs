using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Collect_Manager : MonoBehaviour {

	public static int lists;

	Text text;

	void Start()
	{
		text = GetComponent<Text> ();

		lists = 0;
	}

	void Update()
	{
		if (lists < 0)
			lists = 0;

		text.text = "" + lists + "/11" ;
	}

	public static void AddPoints (int pointsToAdd)
	{
		lists += pointsToAdd;

	}

	public static void Reset()
	{
		lists = 0;
	}
}
