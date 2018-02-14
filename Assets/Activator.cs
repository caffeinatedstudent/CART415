using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activator : MonoBehaviour {


//	SpriteRenderer sr;
	//public Color oldColor;
	//public Color altColor = Color.black;
	//public Renderer rend;

	public KeyCode key;
	bool active = false;
	GameObject note;
	public GameObject explosion;
	public List<Transform> TankParts;

	void Awake(){
//		sr = GetComponent<SpriteRenderer> ();
	//	rend = GetComponent<Renderer> ();
	//	rend.material.color = oldColor;
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(key))
			
		//Assign the changed color to the material.
		StartCoroutine (Pressed ());
		Instantiate (explosion, transform.position, transform.rotation);
		if (Input.GetKeyDown (key) && active) {
			Destroy (note);
		}
		
	}

	void OnTriggerEnter(Collider col){
		active = true;
		if (col.gameObject.tag == "Note")
			note = col.gameObject;
	}

	void OnTriggerExit(Collider col){
		active = false;
	}

	IEnumerator Pressed(){
	//	gameObject.GetComponent<Renderer> ().enabled = false;

	//	rend.material.color = altColor;
	yield return new WaitForSeconds (0.2f);
	//	rend.material.color = oldColor;
		//GetComponent<Renderer> ().enabled = true;


	}	
}
