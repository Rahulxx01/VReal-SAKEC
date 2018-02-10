using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public enum RotationAxix{
		MouseX = 1,
		MouseY = 2
	}
	public RotationAxix axes = RotationAxix.MouseX;

	public float minimumVert = -45.0f;
	public float maximumVert = 45.0f;

	public float sensHorizontal = 10.0f;
	public float sensVertical = 10.0f;

	public float _rotationX = 0;
	
	// Update is called once per frame
	void Update () {

		if (axes == RotationAxix.MouseX) {
			transform.Rotate (0, Input.GetAxis("Mouse X")*sensHorizontal, 0);

		}else if(axes == RotationAxix.MouseY){
			_rotationX -= Input.GetAxis ("Mouse Y") * sensVertical;
			//Clamps vertical angle within the limits of Max and min//
			_rotationX = Mathf.Clamp (_rotationX,minimumVert,maximumVert);

			float rotationY = transform.localEulerAngles.y;

			transform.localEulerAngles = new Vector3 (_rotationX,rotationY,0);
		}
		
	}
}
