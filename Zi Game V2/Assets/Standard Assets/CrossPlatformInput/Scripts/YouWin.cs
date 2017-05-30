using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YouWin : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnCollisionEnter(Collision CollidedObject) { //This is a built in unity Event -- We are creating it, but not really.
		if(CollidedObject.gameObject.tag == "Player") { //Technically, we can use the 'name' like the line above, but by using a tag like a clas we can attach it to all the AI's even if they have different names.
			print ("You Win"); // Refferring to the GameObject with the tag 'EnemyAI'.
		}
}
}