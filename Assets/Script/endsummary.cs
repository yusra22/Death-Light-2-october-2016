using UnityEngine;
using System.Collections;

public class endsummary : MonoBehaviour
{

	void  OnTriggerEnter2D ( Collider2D Col  )
	{
		if(Col.gameObject.name == "Player")
		{
			Application.LoadLevel("end_story");
		}
	}
}
