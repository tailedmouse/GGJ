using UnityEngine;
using System.Collections;

public class PlayerMovement1: MonoBehaviour {
	
	public int speed;
	public int backUpSpeed;
	public int jumpSpeed;
	float rotationSpeed  = 180.0F; 
	int originalSpeed; 
	
	private Rigidbody rb;
	Vector3 newRotationVector;
	
	bool canControlCharacter = true; 

	void Start ()
	{
		rb = GetComponent<Rigidbody>();
		originalSpeed = speed; 
	}
	void FixedUpdate ()
	{

		
		if (canControlCharacter == true) {
			Move();
		}
	}

	
	void Move()
	{


		if ((Input.GetAxis ("Horizontal") > 0)) {//&& Input.GetButton ("Player1_B"))) {

			rb.velocity = rb.gameObject.transform.TransformDirection (Vector3.forward) * speed;
			rb.AddForce (Vector3.back, ForceMode.Acceleration);//Vector3.forward
		}

			if (Input.GetAxis ("Horizontal") < 0) {
				rb.velocity = rb.gameObject.transform.TransformDirection (Vector3.back) * backUpSpeed;
			
				rb.AddForce (Vector3.back, ForceMode.Acceleration);
			
			}

		}


	}