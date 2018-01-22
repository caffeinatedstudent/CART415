using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;



public class DayNight : MonoBehaviour {
	public GameObject darkSpawn;
	public GameObject darkSpawn2;
	public GameObject darkSpawn3;
	public List<GameObject> gameObjects;
	public GameObject tank;
	float coco;
	public Color32 color32 = new Color32(32, 27,32,53);
	public bool ColorOn = false;

	private AudioSource audioSource;
	public AudioClip anthem;

	void Start() {
		this.gameObjects = new List<GameObject> () { darkSpawn, darkSpawn2, darkSpawn3 };
	}


	// Use this for initialization
//	public class IfStatements : MonoBehaviour{



	// Update is called once per frame
	void Update () {
		RotationCheck ();
		transform.Rotate(new Vector3(0.08f,0f,0f));
		if (ColorOn == false) {
			RenderSettings.ambientLight = color32;
		} else if (ColorOn == true) {
			RenderSettings.ambientLight = Color.red;
			}
	}


		void RotationCheck ()
		{
		
		this.coco = transform.localEulerAngles.x;
		Debug.Log(this.coco);


		if (Math.Round(coco,5) == 15.55939) {
				foreach (GameObject obj in gameObjects) {
					Instantiate (tank, obj.transform.position, Quaternion.identity);
						ColorOn = true;
							audioSource = GetComponent<AudioSource>();
								audioSource.clip = anthem;
									audioSource.Play();

				}
		}
		if (Math.Round(coco,4) == 312.2011){
				ColorOn = false;

			}
		}
	}


//}
