using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverTrigger : MonoBehaviour {
 public GameObject target;
	// Use this for initialization
	void Start () {
		 target.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter (Collider hit){
 		if(hit.gameObject.tag == "Player")
 {
		 target.SetActive(true);
}

}
}
