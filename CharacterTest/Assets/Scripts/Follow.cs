using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour {
	private Rigidbody2D alien;
	private Rigidbody2D playerRigid;
	public float moveSpeed = 1f;
	private GameObject player;
	public float num;
	private float jumpSpeed = 350f;
	private float canJump = 0f;
	// Use this for initialization
	void Start () {
		alien = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		 num= Random.Range(0,100);
		 player= GameObject.FindWithTag("Player");
		 float step = moveSpeed * Time.deltaTime;
		 if(player){
			playerRigid= player.GetComponent<Rigidbody2D> ();
			if(num %7 ==0){	
		      transform.position = Vector2.MoveTowards(alien.position, playerRigid.position, step);
			}else if(num %10 ==0){
			  transform.position = Vector2.MoveTowards(alien.position, playerRigid.position, -step);
			}else if(num % 3 ==0){
				alien.AddForce (new Vector2(0, jumpSpeed));
				if(Time.time > canJump){
					canJump = Time.time + .75f;
				}
			}else{

			}
		 }

	}


}
