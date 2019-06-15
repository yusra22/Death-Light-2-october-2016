using UnityEngine;
using System.Collections;

public class Camer_ctrl : MonoBehaviour {

    public GameObject followTarget;
    private Vector3 targetPoz;
    public float moveSpeed;

	public Player_Control player;

	public static bool cameraExists;

	// Use this for initialization
	void Start () {
		player = FindObjectOfType<Player_Control> ();


	
	}
	
	// Update is called once per frame
	void Update () {
        targetPoz = new Vector3(followTarget.transform.position.x, followTarget.transform.position.y, transform.position.z);
        transform.position = Vector3.Lerp(transform.position , targetPoz, moveSpeed * Time.deltaTime);
	
	}

}
