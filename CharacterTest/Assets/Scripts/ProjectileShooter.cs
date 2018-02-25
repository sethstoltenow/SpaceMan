using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileShooter : MonoBehaviour {
	public GameObject Projectile;
	public Transform spawnPoint;
	public Transform gun;
	private float projSpeed = 20.0f;
	// Use this for initialization
	void Start () {
		//Projectile = Resources.Load("Projectile") as GameObject;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) {
			GameObject newProjectile = Instantiate (Projectile) as GameObject;
			//newProjectile.transform.position = spawnPoint.position;
			//GameObject newProjectile = (GameObject)Instantiate(
			//	Projectile,
			//	spawnPoint.position,
			//	spawnPoint.rotation);
			newProjectile.transform.position = spawnPoint.transform.position;
			//Rigidbody2D
			Rigidbody2D rb = newProjectile.GetComponent<Rigidbody2D> ();
			//rb.velocity = spawnPoint.transform.rotation;
			//Vector2 vector = gun.transform.forward*projSpeed;
			rb.velocity = gun.transform.right*projSpeed;;
			Destroy (newProjectile, 2.0f);
		}
		
	}

	public Vector2 Vector2FromAngle(float a)
	{
		a *= Mathf.Deg2Rad;
		return new Vector2(Mathf.Cos(a), Mathf.Sin(a));
	}
}
