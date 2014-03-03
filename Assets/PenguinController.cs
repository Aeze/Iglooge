using UnityEngine;
using System.Collections;

public class PenguinController : MonoBehaviour {


	public float maxSpeed;
	
	private RaycastHit hit;
	
	// Use this for initialization
	void Start () {
	
	}
	
	void FixedUpdate () {
		KeepUpright();
		GetInputs();
		MoveForward();
	}
	
	void KeepUpright () {
		if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down), out hit)) {
			transform.up = hit.normal;
		}
	}
	
	void MoveForward() {
		float speed = (transform.rotation.eulerAngles.x / 1);
		
		Debug.Log (speed);
		
		transform.Translate( transform.forward * speed * Time.deltaTime);
	}
	
	void GetInputs () {
		
		if(Input.GetKeyDown(KeyCode.A)) {
			Debug.Log("AAAA");
			rigidbody.AddForce(-30,0,0);
		}
		if(Input.GetKeyDown(KeyCode.D)) {
			Debug.Log("DDDD");
			rigidbody.AddForce(30,0,0);
			
		}
	}
	
	
}
