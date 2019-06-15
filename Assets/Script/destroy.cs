using UnityEngine;
using System.Collections;

public class destroy : MonoBehaviour {

	public float destroyTime;

	// Use this for initialization
	void Start () {
	
		Destroy(this.gameObject, destroyTime);
	}
	 
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other)
	{ 
		if (other.gameObject.name =="sword") {
			DontDestroyOnLoad (this.gameObject);
		} else {
			Destroy (this.gameObject);
		}
	}

}
