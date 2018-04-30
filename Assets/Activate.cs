using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activate : MonoBehaviour {


	public AudioSource Scored;

	public Color oldColor;
	public bool CreateMode;

	public bool inTrigger;
	public bool isPlaying;

	public KeyCode key;
	bool active = false;
	GameObject note;
	public GameObject n;

	public GameObject bodyColor;
	public GameObject turretColor;


 //public GameObject shot;
 //public Transform shotSpawn; 
 //public float fireRate;

 //private float nextFire; 

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
		if(CreateMode){
			if(Input.GetKeyDown(key))
			Instantiate(n,transform.position,Quaternion.identity);
		}else{
	  
		if(Input.GetKeyDown(key))

			//	shot = Instantiate(shot) as GameObject;
				//  nextFire = Time.time + fireRate;
 					  //GameObject clone = 
  				//	 shot.transform.position = shotSpawn.transform.position;
   				//		shot.GetComponent<Rigidbody>().AddForce(Vector3.up*400);
		//Assign the changed color to the material.
		StartCoroutine (Pressed ());
		if(Input.GetKeyDown(key)){
			Scored.Play();
		}
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
		//	Instantiate (Effect_Explosion, transform.position, Quaternion.identity);
			Destroy (note);
		}



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