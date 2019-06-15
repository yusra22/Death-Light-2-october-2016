using UnityEngine;
using System.Collections;

public class ghostfollow : MonoBehaviour {

		public GameObject target;
		public float ratio=0.05f;
		bool gotIt;
		public float range;
		public GameObject explosion;


		// Use this for initialization
		void Start () {

			if (target == null)
			target = GameObject.Find ("Player");

		}

		// Update is called once per frame
		void Update () 
	{

		transform.position = Vector3.MoveTowards (transform.position, target.transform.position, ratio);
	}

}

