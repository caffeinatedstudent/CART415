using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DungeonCamera : MonoBehaviour {
	
	public float damping = 1;
	Vector3 offset;
	public Transform target;

	void Start() {
		offset = transform.position - target.transform.position;
		target = GameObject.FindGameObjectWithTag("Player").transform;
	}

	void LateUpdate() {
		Vector3 desiredPosition = target.transform.position + offset;
		Vector3 position = Vector3.Lerp(transform.position, desiredPosition, Time.deltaTime * damping);
		transform.position = position;

		transform.LookAt(target.transform.position);
	}
}