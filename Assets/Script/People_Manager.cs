using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class People_Manager : MonoBehaviour {

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

		text.text = "" + lists + "/3" ;
	}

	public static void AddPoints3 (int pointsToAdd2)
	{
		lists += pointsToAdd2;

	}

	public static void Reset()
	{
		lists = 0;
	}
}