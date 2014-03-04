using UnityEngine;
using System.Collections;

public class PenguinController : MonoBehaviour
{
		public WheelCollider rightfront;
		public WheelCollider leftfront;
		public WheelCollider rightback;
		public WheelCollider leftback;


		public float acceleration = 500;
		public float maxSpeed = 1000;
		public float maxSteer = 25.0f;
		public float steer = 0.0f;



		
	
		// Use this for initialization
		void Start ()
		{
				rigidbody.centerOfMass = new Vector3 (0, -1, 0);

		}
	
		void Update ()
		{
				rigidbody.AddForce (-transform.up * 1000);
				steer = Input.GetAxis ("Horizontal") * maxSteer;
				rightfront.steerAngle = steer;
				leftfront.steerAngle = steer;


				rigidbody.velocity += (rigidbody.velocity * 0.12f * Time.deltaTime);

		}
	
}
