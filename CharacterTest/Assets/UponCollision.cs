using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UponCollision : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter2D(Collision2D coll) {
		//Instantiate an explosion object at location
		//if (coll.gameObject.tag == "Enemy")
			Destroy (gameObject);

	}
}
