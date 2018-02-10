using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookWalk : MonoBehaviour {
	public Transform vrCamera;
	public float toggleAngle=30.0f;
	public float speed = 3.0f;
	public bool moveForward;
	private CharacterController characterController;
	// Use this for initialization
	void Start () {
		characterController = GetComponent<CharacterController> ();
	}
	
	// Update is called once per frame
	void Update () {

		if (vrCamera.eulerAngles.x >= toggleAngle && vrCamera.eulerAngles.x < 90.0f) {
			moveForward = true;
		} else {
			moveForward = false;
		}


		if(moveForward){
			Vector3 forward = vrCamera.TransformDirection (Vector3.forward);
			characterController.SimpleMove (forward*speed);

		}
		
	}
}
