using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class playerhealthmanager : MonoBehaviour {

	public int playermaxhealth;
	public int playercurrenthealth;

	private bool flashActiveTime;
	public float flashLengthTime;
	private float flashCounter;

	private SpriteRenderer playersprite;

	private Sfx_manager sfxMan;

	public float gamereload;

	// Use this for initialization
	void Start () {
		playercurrenthealth = playermaxhealth;
		sfxMan = FindObjectOfType<Sfx_manager> ();

		playersprite = GetComponent<SpriteRenderer> ();

	
	}
	
	// Update is called once per frame
	void Update () {
		if (playercurrenthealth <= 0) 
		{
			gamereload -= Time.deltaTime;
			if (gamereload < 0) {
				Application.LoadLevel (Application.loadedLevel);
				Destroy (gameObject);
				//gameObject.SetActive (false);

			}
		}

		if (flashActiveTime) 
		{
			if (flashCounter > flashLengthTime * .66f) 
			{
				playersprite.color = new Color (playersprite.color.r, playersprite.color.g, playersprite.color.b, 0f);	
			} 
			else if (flashCounter > flashLengthTime * .33f) 
			{
				playersprite.color = new Color (playersprite.color.r, playersprite.color.g, playersprite.color.b, 1f);
			} 
			else if (flashCounter > 0f) 
			{
				playersprite.color = new Color (playersprite.color.r, playersprite.color.g, playersprite.color.b, 0f);
			}
			else
			{	
				playersprite.color = new Color (playersprite.color.r, playersprite.color.g, playersprite.color.b, 1f);	
				flashActiveTime = false;
			}

			flashCounter -= Time.deltaTime;
		}
		if (playercurrenthealth > playermaxhealth) 
		{
			playercurrenthealth = playermaxhealth;
		}
	}

	public void KillPlayer(int damageToLose)
	{
		playercurrenthealth -= damageToLose;

		flashActiveTime = true;
		flashCounter = flashLengthTime;

		sfxMan.playerhurt.Play ();
	}

	public void SetMaxHealth()
	{
		playercurrenthealth = playermaxhealth;
	}
}

