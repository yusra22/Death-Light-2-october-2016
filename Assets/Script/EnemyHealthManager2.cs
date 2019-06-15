using UnityEngine;
using System.Collections;

public class EnemyHealthManager2 : MonoBehaviour {

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
			Application.LoadLevel ("Scene6");
			Destroy (gameObject);

		}

	}

	public void KillEnemy(int damageToLose2)
	{
		currenthealth -= damageToLose2;
	}

	public void SetMaxHealth()
	{
		currenthealth = maxhealth;
	}
}