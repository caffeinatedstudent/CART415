using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShellImpact : MonoBehaviour {

	public float power = 20.0f;
	public float radius = 2.0f;
	public float upForce = 0f;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter (Collider hit){
 		if(hit.gameObject.tag == "ball")
 {
			Vector3 explosionPosition = this.transform.position;
			Collider[] colliders = Physics.OverlapSphere (explosionPosition, radius);
			foreach (Collider hi in colliders) {
			
				Rigidbody rb = hit.GetComponent<Rigidbody>();
				if (rb != null) {

					rb.AddExplosionForce (power, explosionPosition, radius, upForce, ForceMode.Impulse);
				}
			}
			

 }
}
 //void AddScore () {
 //PlayerPrefs.SetInt("Score", PlayerPrefs.GetInt("Score")+gm.GetComponent<NewGameManager>().GetScore());
 

 //}
}

