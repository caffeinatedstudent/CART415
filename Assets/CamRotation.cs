using UnityEngine;
using System.Collections;

public class CamRotation : MonoBehaviour 
{
	private float x;
	private float y;


	void Update()
	{
		float rotateX = Random.Range (0, 50);
		transform.eulerAngles = new Vector3(0,0,rotateX);
	}
}