using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteImpact : MonoBehaviour {
// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter (Collider hit){
 		if(hit.gameObject.tag == "Shell")
 {
      Destroy(hit.gameObject); // destroy the other collided object
      // destroy the object to which script is attached              
 }
}
}
