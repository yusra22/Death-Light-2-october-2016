using UnityEngine;
using System.Collections;

public class EnemyPatrol : MonoBehaviour
{

	public float moveSpeed;
	public bool moveRight;

	private new Rigidbody2D rigidbody2D;
	private bool hittingWall;
	private bool notAtEdge;

	// Use this for initialization
	void Start ()
	{
		rigidbody2D = GetComponent<Rigidbody2D> ();
	}

	// Update is called once per frame
	void Update ()
	{	
			if (moveRight ) {
				transform.localScale = new Vector4 (-0.5f, 0.5f, 0.5f);
				rigidbody2D.velocity = new Vector2 (moveSpeed, rigidbody2D.velocity.y);
			} else {
				transform.localScale = new Vector4 (0.5f, 0.5f, 0.5f);
				rigidbody2D.velocity = new Vector2 (-moveSpeed, rigidbody2D.velocity.y);
			}
		}
}



