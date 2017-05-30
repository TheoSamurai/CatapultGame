using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour {

	bool isPressed;
	public GameObject bulletPrefab;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		isPressed = Input.GetKey (KeyCode.Mouse0);
		// print (isPressed);
	}

	void FixedUpdate() {
		if (isPressed == true) {
			Instantiate (bulletPrefab, transform.position, transform.rotation);
		}
	}

	private void OnCollisionEnter(Collision collidedObject) {
		if (collidedObject.gameObject.tag == "EnemyAI") {
			Destroy (collidedObject.gameObject);
		}
		if(collidedObject.gameObject.tag == "Wall") { //Technically, we can use the 'name' but by using a tag like a class we can attach it to all the AI's even if they have different names.
			print ("You Win!!"); // Refferring to the GameObject with the tag 'Wall'.
		}
	}
}
