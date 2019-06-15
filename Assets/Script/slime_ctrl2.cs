using UnityEngine;
using System.Collections;

public class slime_ctrl2 : MonoBehaviour {

	private Vector3 player;
	private Vector2 Playerdirection;
	private float xdif;
	private float ydif;
	public float speed;
	private float distance;

	void Start()
	{

	}

	void Update()
	{
		distance = Vector2.Distance (player, transform.position);
		player = GameObject.Find ("Player").transform.position;
		if (distance < 5) {
			xdif = player.x - transform.position.x;
			ydif = player.y - transform.position.y;
			Playerdirection = new Vector2 (xdif, ydif);
			GetComponent<Rigidbody2D> ().AddForce (Playerdirection.normalized * speed);

		}

	}
}
