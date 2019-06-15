using UnityEngine;
using System.Collections;

public class slime_ctrl1 : MonoBehaviour {

	public float moveSpeed;

	private Rigidbody2D myRigidbody;

	private bool moving;

	public float timeBetweenMove;
	private float timeBetweenMoveCounter;
	public float timeToMove;
	private float timeToMoveCounter;

	private Vector3 moveDirection;

	public float gamereload;
	private bool reloading;
	private GameObject player;

	// Use this for initialization
	void Start () {

		myRigidbody = GetComponent<Rigidbody2D> ();

		timeBetweenMoveCounter = Random.Range (timeBetweenMove * 0.75f, timeBetweenMove * 1.25f);
		timeToMoveCounter = Random.Range (timeToMove * 0.75f, timeBetweenMove * 1.25f);


	
	}
	
	// Update is called once per frame
	void Update () {

		if (moving) {
			timeToMoveCounter -= Time.deltaTime;
			myRigidbody.velocity = moveDirection;


			if (timeToMoveCounter < 0f) {
				moving = false;
				//timeBetweenMoveCounter = timeBetweenMove;
				timeBetweenMoveCounter = Random.Range (timeBetweenMove * 0.75f, timeBetweenMove * 1.25f);
			}

		} else {
			timeBetweenMoveCounter -= Time.deltaTime;
			myRigidbody.velocity = Vector2.zero;

			if (timeBetweenMoveCounter < 0f) {
				moving = true;
				//timeToMoveCounter = timeToMove;
				timeToMoveCounter = Random.Range (timeToMove * 0.75f, timeBetweenMove * 1.25f);

				moveDirection = new Vector3 (Random.Range (-1f, 1f) * moveSpeed, Random.Range (-1f, 1f) * moveSpeed, 0f);
	
			}
			if (reloading) {
				gamereload -= Time.deltaTime;
				if (gamereload < 0) {
					Application.LoadLevel (Application.loadedLevel);
					player.SetActive (true);
				}
			}
		}
	}

	void OnCollisionEnter2D(Collision2D other)
	{
		/*if (other.gameObject.name == "Player") 
		{
			//Destroy (other.gameObject);
			other.gameObject.SetActive(false);

			reloading = true;
			player = other.gameObject;
		} */
	}
}