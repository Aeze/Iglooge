using UnityEngine;
using System.Collections;

public class PenguinController : MonoBehaviour
{
		public WheelCollider rightfront;
		public WheelCollider leftfront;
		public WheelCollider rightback;
		public WheelCollider leftback;
	
		public float acceleration = 0.12f;
		public float maxPower = 1000;
		public float maxSteer = 30.0f;
		public float steer = 0.0f;
		public float power = 0.0f;
		public float maxSpeed = 0.0f;
		

		public float elapsedTime = 0;
		public static bool raceActive = true;


		public float velocity = 0.0f;
		private Vector3 downwardsForce;
	


		// Use this for initialization
		void Start ()
		{
				rigidbody.centerOfMass = new Vector3 (0, -1, 0);

		}
	
		void Update ()
		{
				//set racetime (SHOULD MOVE THIS)
				if (raceActive) {
						elapsedTime += Time.deltaTime;
				}

				//max out speed based on maxSpeed
				velocity = rigidbody.velocity.magnitude;
				if (velocity > maxSpeed) {
						rigidbody.velocity = (rigidbody.velocity.normalized * maxSpeed);
				}
				
				//push penguind down based on current velocity
				downwardsForce = (-transform.up * (velocity / 2));
				rigidbody.AddForce (downwardsForce);
				
				//get steering input
				steer = Input.GetAxis ("Horizontal") * maxSteer;
				rightfront.steerAngle = steer;
				leftfront.steerAngle = steer;

				//apply angular drag based on velocity to smooth turning at high speeds
				if (velocity > 30) {
						rigidbody.angularDrag = velocity / 2;
				}
				
				//apply acceleration to wheels to speed things up (SHOULD SIMPLIFY THIS)
				if (power < maxPower) {
						power += (power + 1) * acceleration;
				} 
				rightback.motorTorque = power;
				rightfront.motorTorque = power;
				leftback.motorTorque = power;
				leftfront.motorTorque = power;
				
				


		}

		void OnGUI ()
		{
		
				GUI.Label (new Rect (10, 10, 100, 20), elapsedTime.ToString ());
				GUI.Label (new Rect (10, 30, 100, 20), velocity.ToString ());

		}

		public static void RaceFinished ()
		{
				raceActive = false;
		}
	
}
