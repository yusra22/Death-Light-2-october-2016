using UnityEngine;
using System.Collections;

public class HurtEnemies : MonoBehaviour {
	
	public int damageToLose;
	public GameObject damageExplode;
	public Transform hitPoint;
	private Sfx_manager sfxMan;



	// Use this for initialization
	void Start () {
		sfxMan = FindObjectOfType<Sfx_manager> ();
	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerStay2D (Collider2D coll)
	{	
		if (coll.gameObject.tag == "Enemy") 
		{
			//Destroy (coll.gameObject);
			coll.gameObject.GetComponent<EnemyHealthManager>().KillEnemy(damageToLose);
			Instantiate (damageExplode, transform.position, transform.rotation);
			sfxMan.fleshcut.Play ();
		}

	}
}
