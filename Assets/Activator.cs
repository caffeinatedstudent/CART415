using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activator : MonoBehaviour {


	public AudioSource Scored;

	public Color oldColor;

	public bool inTrigger;
	public bool isPlaying;

	public KeyCode key;
	bool active = false;
	GameObject note;
	public Transform Effect_Explosion;

	public GameObject bodyColor;
	public GameObject turretColor;
	void Awake(){

		oldColor = bodyColor.GetComponentInChildren<MeshRenderer> ().material.color;

	}
	// Use this for initialization
	void Start () {
		Scored = GetComponent<AudioSource> ();
		inTrigger = false;
		isPlaying = false;
	}
	
	// Update is called once per frame
	void Update () {

	  
		if(Input.GetKeyDown(key))
			
		//Assign the changed color to the material.
		StartCoroutine (Pressed ());
		
		if (Input.GetKeyUp (key)) {
			if (isPlaying) {
				// turn music OFF
				Scored.Pause ();

				isPlaying = false;
			}
			inTrigger = false;
		
		}
		if (Input.GetKeyDown (key) && active) {
			if (inTrigger == true) {
				Scored.Play();
				isPlaying = true;
			}
			Instantiate (Effect_Explosion, transform.position, Quaternion.identity);
			Destroy (note);
		}

	}

	void OnTriggerEnter(Collider col){
		active = true;
		if (col.gameObject.tag == "Note")
			note = col.gameObject;
		inTrigger = true;

	}

	void OnTriggerExit(Collider col){
		active = false;
		inTrigger = false;
		isPlaying = false;

	}

	IEnumerator Pressed(){
		bodyColor.GetComponentInChildren<MeshRenderer>().material.color = new Color(0f,0f,0f,0f);
		turretColor.GetComponentInChildren<MeshRenderer>().material.color = new Color(0f,0f,0f,0f);
 
	yield return new WaitForSeconds (0.2f);
		bodyColor.GetComponentInChildren<MeshRenderer>().material.color = oldColor;
		turretColor.GetComponentInChildren<MeshRenderer>().material.color = oldColor;
	

	}	
}
//j.dbap_bformat
//miraweb
//MAXADUINO
// ml.star