using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class Player_Control : MonoBehaviour
{

    public float moveSpeed;
    private Animator anim;
    private bool playermove;
    private Vector2 lastMove;
    private Rigidbody2D myribod;
	private GameObject gunPoint;

	public GameObject sword;

	private bool playerExists;

	private bool attacking;
	public float attackTime;
	private float attackTimeCounter;

	public bool canMove;

	private Sfx_manager sfxMan;

    void Start()
    {
		anim = GetComponent<Animator>();
		myribod = GetComponent<Rigidbody2D>();
		sfxMan = FindObjectOfType<Sfx_manager> ();

		//if (!playerExists) 
		//{
		//	playerExists = true;
		//	DontDestroyOnLoad (transform.gameObject);
		//} else {
		//	Destroy (gameObject);
		//}
     
    }

    void Update()
    {

        playermove = false;

		if (!canMove) 
		{
			myribod.velocity = Vector2.zero;
			return;
		}

		if (!attacking) 
		{
        
            if (CrossPlatformInputManager.GetAxis("Horizontal") > 0.5f || CrossPlatformInputManager.GetAxis("Horizontal") < -0.5f)
            {
                myribod.velocity = new Vector2(CrossPlatformInputManager.GetAxis("Horizontal") * moveSpeed, myribod.velocity.y);
                //transform.Translate(new Vector3(CrossPlatformInputManager.GetAxis("Horizontal") * moveSpeed * Time.deltaTime, 0f, 0f));
                playermove = true;
                lastMove = new Vector2(CrossPlatformInputManager.GetAxis("Horizontal"), 0f);
                
            }

            if (CrossPlatformInputManager.GetAxis("Vertical") > 0.5f || CrossPlatformInputManager.GetAxis("Vertical") < -0.5f)
            {
                myribod.velocity = new Vector2(myribod.velocity.x, CrossPlatformInputManager.GetAxis("Vertical") * moveSpeed);
                // transform.Translate(new Vector3(0f, CrossPlatformInputManager.GetAxis("Vertical") * moveSpeed * Time.deltaTime, 0f));
                playermove = true;
                lastMove = new Vector2(0f, CrossPlatformInputManager.GetAxis("Vertical"));
               
            }
        	if (CrossPlatformInputManager.GetAxis("Horizontal")==0 && CrossPlatformInputManager.GetAxis("Vertical")==0)
       	 	{
            GetComponent<AudioSource>().Pause();
			
        	}
        	else
        	{
            GetComponent<AudioSource>().UnPause();
        	}


            if (CrossPlatformInputManager.GetAxis("Horizontal") < 0.5f && CrossPlatformInputManager.GetAxis("Horizontal") >-0.5f)
        	{
            myribod.velocity = new Vector2(0f, myribod.velocity.y);
        	}
        	if (CrossPlatformInputManager.GetAxis("Vertical") < 0.5f && CrossPlatformInputManager.GetAxis("Vertical") > -0.5f)
        	{
            myribod.velocity = new Vector2(myribod.velocity.x,0f);
        	}

			if (Input.GetKeyDown (KeyCode.J)) {
				attackTimeCounter = attackTime;
				attacking = true;
				myribod.velocity = Vector2.zero;
				anim.SetBool ("Attack", true);
			}
		}


		if (attackTimeCounter >= 0) 
		{
			attackTimeCounter -= Time.deltaTime;
		}

		if (attackTimeCounter <= 0) 
		{
			attacking = false;
			anim.SetBool ("Attack", false);
		}	

		anim.SetFloat("MoveX", CrossPlatformInputManager.GetAxis("Horizontal"));
		anim.SetFloat("MoveY", CrossPlatformInputManager.GetAxis("Vertical"));
		anim.SetBool("PlayerMove", playermove);
		anim.SetFloat("LastMoveX", lastMove.x);
		anim.SetFloat("LastMoveY", lastMove.y);
	}
			

	public void attackbutton()
	{
		attackTimeCounter = attackTime;
		attacking = true;
		myribod.velocity = Vector2.zero;
		anim.SetBool ("Attack", true);
		sfxMan.SwordSwing.Play ();
	}

	void OnDestroy() {
		
		if (!playerExists) 
		{
			playerExists = true;
			DontDestroyOnLoad (transform.gameObject);
		} else {
			Destroy (gameObject);
		}
	}
}

