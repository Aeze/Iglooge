using UnityEngine;
using System.Collections;

public class RaceManager : MonoBehaviour
{


		public bool paused = false;
		public float timeToStart = 3.0f;	
		
		public GameObject[] penguins;

		// Private reference
		private static RaceManager _instance;

		public static RaceManager instance {
				get {
						// If _instance hasn't been set, we grab it from the scene
						if (_instance == null)
								_instance = GameObject.FindObjectOfType<RaceManager> ();
						return _instance;
				}
		}

		void Awake ()
		{
				penguins = GameObject.FindGameObjectsWithTag ("Penguin");
			
		}
		void Start ()
		{
				PauseGame ();
				Invoke ("UnpauseGame", 3.0f);
		}
	

		void Update ()
		{
	
		}
		
	

		void PauseGame ()
		{
				foreach (GameObject penguin in penguins) {
						penguin.rigidbody.constraints = RigidbodyConstraints.FreezeAll;
				}
				
		}

		void UnpauseGame ()
		{
				foreach (GameObject penguin in penguins) {
						penguin.rigidbody.constraints = RigidbodyConstraints.None;
				}
		}
}
