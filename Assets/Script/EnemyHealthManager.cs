using UnityEngine;
using System.Collections;

public class EnemyHealthManager : MonoBehaviour {

	public int maxhealth;
	public int currenthealth;



	// Use this for initialization
	void Start () {
		currenthealth = maxhealth;

	}

	// Update is called once per frame
	void Update () {
		if (currenthealth <= 0) 
		{
			Destroy (gameObject);

		}

	}

	public void KillEnemy(int damageToLose)
	{
		currenthealth -= damageToLose;
	}

	public void SetMaxHealth()
	{
		currenthealth = maxhealth;
	}
}
