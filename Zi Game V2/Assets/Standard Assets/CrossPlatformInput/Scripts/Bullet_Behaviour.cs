using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Behaviour : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void FixedUpdate() {
		transform.position += transform.forward; // += will take the first value and add it or make the other value the same
	}
	// TutorialsPoint.com -- Logical operator 

	private void OnCollisionEnter(Collision CollidedObject) { //This is a built in unity Event -- We are creating it, but not really.
		// print (CollidedObject.gameObject.name); //Using this we can find out what game object/object hit our car -- Only the name, though. We can also find out the tag!
		if(CollidedObject.gameObject.tag == "EnemyAI") { //Technically, we can use the 'name' like the line above, but by using a tag like a clas we can attach it to all the AI's even if they have different names.
			print ("Enemy Hit!");
			Destroy (CollidedObject.gameObject); // Refferring to the GameObject with the tag 'EnemyAI'.
		}
	}
}
