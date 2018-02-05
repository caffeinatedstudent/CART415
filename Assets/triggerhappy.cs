using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerhappy : MonoBehaviour {

	// Use this for initialization
	public GameObject door; // This is where you reference the door you want to destroy

	void OnCollisionEnter(Collision other) {

		if(other.collider.tag == "Player") {
			Destroy(door);
			 //This will destroy the pressure plate after it has been triggered 
		}
	}
}