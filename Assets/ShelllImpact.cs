using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShelllImpact : MonoBehaviour {

GameObject note, gm;
	// Use this for initialization
	void Start () {
		  gm = GameObject.Find("NewGameManager");

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter (Collider hit){
 		if(hit.gameObject.tag == "Note")
 {
      Destroy(hit.gameObject); // destroy the other collided object
      // destroy the object to which script is attached
      gm.GetComponent<New2GameManager>().AddStreak();
      AddScore();              
 }
}
 void AddScore () {
 PlayerPrefs.SetInt("Score", PlayerPrefs.GetInt("Score")+gm.GetComponent<New2GameManager>().GetScore());
 

 }
}

