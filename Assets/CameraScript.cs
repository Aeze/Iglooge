using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {

	public Transform target;
	
	public float distance = 10.0f;
	public float height = 10.0f;
	public float heightDamping = 2.0f;
	public float rotationDamping = 3.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float desiredRotationAngle = target.eulerAngles.y;
		float desiredHeight = target.position.y + height;
		
		float currentRotationAngle = transform.eulerAngles.y;
		float currentHeight = transform.position.y;
		
		
		currentRotationAngle = Mathf.Lerp(currentRotationAngle, desiredRotationAngle, rotationDamping * Time.deltaTime);
		currentHeight = Mathf.Lerp(currentHeight, desiredHeight, heightDamping * Time.deltaTime);
		
		Quaternion currentRotation = Quaternion.Euler (0, currentRotationAngle, 0);
		
		transform.position = target.position;
		transform.position -= currentRotation * Vector3.forward * distance;
		Vector3 temp = transform.position;
		temp.y = currentHeight; 
		transform.position = temp;
		
		transform.LookAt(target);
	
	}
}
