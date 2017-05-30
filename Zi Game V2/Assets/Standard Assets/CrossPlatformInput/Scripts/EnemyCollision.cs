using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnCollisionEnter(Collision collidedObject) {
		if (collidedObject.gameObject.name == "Bullet") {
			Destroy (collidedObject.gameObject);
		}
	}

}