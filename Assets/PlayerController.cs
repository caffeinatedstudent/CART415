using UnityEngine;
using System.Collections;

[System.Serializable]



public class PlayerController : MonoBehaviour 
{
	public KeyCode key;
	
	
public GameObject _instance;
 public GameObject shot;
 public Transform shotSpawn; 
 public float fireRate;

 private float nextFire; 

 void Update () 
 {
  if (Input.GetKeyDown(key) && Time.time > nextFire) 
  {
   _instance = Instantiate(shot) as GameObject;
   _instance.gameObject.tag= "Shell";
   nextFire = Time.time + fireRate;
   //GameObject clone = 
   _instance.transform.position = shotSpawn.transform.position;
   _instance.GetComponent<Rigidbody>().AddForce(Vector3.up*9000);
  }

 }

 
	
}