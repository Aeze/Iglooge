using UnityEngine;
using System.Collections;

public class RaceManager : MonoBehaviour
{


		public bool paused = false;
		public float timeToStart = 3.0f;	
		
		

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
			
		}
		void Start ()
		{
			
	
		}
	

		void Update ()
		{
	
		}
		
	

		void PauseGame ()
		{
				
		}

		void UnpauseGame ()
		{
				
			
		}
}
