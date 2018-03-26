using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinusScore : MonoBehaviour {

	public NewGameManager newmanager;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter (Collider hit){

		if(hit.gameObject.tag == "ball")
		{

			MinusScore();

		}
}


