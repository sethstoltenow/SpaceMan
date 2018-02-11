using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoceScript : MonoBehaviour {

	//private bool isDead = false;
	private Rigidbody2D spaceMan;

	public float moveSpeed = 5f;
	private float jumpSpeed = 350f;
	//private float jumpDelay = .5f;
	private float canJump = 0f;

	// Use this for initialization
	void Start () {
		spaceMan = GetComponent<Rigidbody2D> ();
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.D))
			transform.Translate (new Vector2 (1, 0) * moveSpeed * Time.deltaTime);

		if (Input.GetKey (KeyCode.A))
			transform.Translate (new Vector2 (-1, 0) * moveSpeed * Time.deltaTime);

		/*if (Input.GetKey (KeyCode.W)) 
		{
			spaceMan.AddForce (new Vector2(0, jumpSpeed));
		}*/
		
	}

	void OnCollisionStay2D(Collision2D coll ) // C#, type first, name in second
	{
		if (coll.gameObject.tag == "World" && (Input.GetKey (KeyCode.W)) && Time.time > canJump)
		{
			//Jump Script
			spaceMan.AddForce (new Vector2(0, jumpSpeed));
			canJump = Time.time + .75f;

		}





	}
}
