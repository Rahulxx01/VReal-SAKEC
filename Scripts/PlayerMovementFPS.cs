using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementFPS : MonoBehaviour {
	public float speed = 6.0F;
	public float jumpSpeed = 8.0F;
	public float gravity = 20.0F;
	private Vector3 moveDirection = Vector3.zero;
	// Use this for initialization
	void Start () {
		

	}
	
	// Update is called once per frame
	void Update () {
		/*float deltaX = Input.GetAxis ("Horizontal") * speed;
		float deltaZ = Input.GetAxis ("Vertical") * speed;
		Vector3 movement = new Vector3 (deltaX, 0, deltaZ);

		//limits max speed of player//
		movement = Vector3.ClampMagnitude (movement, speed);

		movement.y = gravity;

		movement *= Time.deltaTime;//speed of player does not change depending of frame rate//

		movement = transform.TransformDirection (movement);
		_characterController.Move (movement);*/
		//movePlayer ();

		CharacterController controller = GetComponent<CharacterController>();
		if (controller.isGrounded) {
			moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
			moveDirection = transform.TransformDirection(moveDirection);
			moveDirection *= speed;
			if (Input.GetButton("Jump"))
				moveDirection.y = jumpSpeed;

		}
		moveDirection.y -= gravity * Time.deltaTime;
		controller.Move(moveDirection * Time.deltaTime);
		
	}
	public void movePlayer(){
		float horizontal = Input.GetAxis ("Horizontal");
		float vertical = Input.GetAxis ("Vertical");
//		Vector3 moveDirSide = transform.right * horizontal * speed;
//		Vector3 moveDirForward = transform.forward * vertical * speed;
		/*_characterController.SimpleMove (moveDirSide);
		_characterController.SimpleMove (moveDirForward);*/
	}
}
