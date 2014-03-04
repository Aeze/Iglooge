using UnityEngine;
using System.Collections;

public class PenguinController : MonoBehaviour
{


		public float maxSpeed;
		public float acceleration;
		public float currentSpeed;
		public float rotationSpeed;
	
		private RaycastHit hit;
		private Vector3 currentRotation;
	
		// Use this for initialization
		void Start ()
		{
				currentSpeed = 0.0f;
		}
	
		void FixedUpdate ()
		{
				KeepUpright ();
				MoveForward ();

			
		}
	
		void KeepUpright ()
		{
				Vector3 relativeLeft = (transform.position + new Vector3 (-1, 0, 1));
				Vector3 relativeRight = (transform.position + new Vector3 (1, 0, 1));
				Quaternion targetRotation = Quaternion.LookRotation (relativeLeft);

				
				transform.localRotation = Quaternion.Slerp (transform.localRotation, targetRotation, Time.deltaTime);
		}



		void MoveForward ()
		{
			
		}
	


	
}
