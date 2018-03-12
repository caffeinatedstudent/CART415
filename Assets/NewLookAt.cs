using UnityEngine;
using System.Collections;

public class NewLookAt : MonoBehaviour {

	public Transform Capsule1;
	public Transform Capsule2;
	public Vector3 center;

	void Update () {
		center = ((Capsule2.position - Capsule1.position)/2.0f) + Capsule1.position;
		transform.LookAt(center);
	}
}