using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
	
	public Vector3 initialImpulse;
	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody>().AddForce(initialImpulse, ForceMode.Impulse);
	} 
	// Update is called once per frame
	void Update () {

	}
}﻿