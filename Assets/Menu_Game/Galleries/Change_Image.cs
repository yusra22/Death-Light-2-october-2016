using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Change_Image : MonoBehaviour {

	public Image image;


	// Use this for initialization
	void Start () {
		
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void ChangeImage (string nameImage) {

		image.sprite = Resources.Load<Sprite> ("Image/"+nameImage) as Sprite;
		
		}
}
