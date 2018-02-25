using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour {
	private Rigidbody2D alien;
	private Rigidbody2D playerRigid;
	public float moveSpeed = 15f;
	private GameObject player;
	public float num;
	private float jumpSpeed = 350f;
	private float canJump = 0f;
	private float canLeap= 0f;
	private int counter=0;



	// Use this for initialization
	void Start () {
		alien = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		 num= Random.Range(0,4);
	}


	void OnCollisionStay2D(Collision2D col){
		if (col.gameObject.tag == "World" && Time.time > canJump){
			player= GameObject.FindWithTag("Player");
			float step = moveSpeed * Time.deltaTime;
			if(player){
				playerRigid= player.GetComponent<Rigidbody2D> ();
				moveAlien(playerRigid,step,num);
			}
		}
	  }

	void moveAlien(Rigidbody2D thePlayer, float step, float randomNumber){
		 if(randomNumber==0){
			 //move closer
		   transform.position = Vector2.MoveTowards(alien.position, playerRigid.position, step);
		 }else if(randomNumber==1){
			 //move away
		    transform.position = Vector2.MoveTowards(alien.position, playerRigid.position, -step);
		 }else if(randomNumber==2){
		    //move closer and jump
			transform.position = Vector2.MoveTowards(alien.position, playerRigid.position, step);
				alien.AddForce (new Vector2(0, jumpSpeed));
				if(Time.time > canJump){
					canJump = Time.time + .75f;
				}
			
			}else{
			 //move away and jump
            	transform.position = Vector2.MoveTowards(alien.position, playerRigid.position, -step);
		
				alien.AddForce (new Vector2(0, jumpSpeed));
				if(Time.time > canJump){
					canJump = Time.time + .75f;
				}
			
			}
	}


}
