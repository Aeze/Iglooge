using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour
{

		public Texture2D logoTexture;

		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{
	
		}

		void OnGUI ()
		{
				GUI.BeginGroup (new Rect (Screen.width / 2 - 150, 50, 300, 200));
				//main menu box
				GUI.Box (new Rect (0, 0, 300, 200), "");

				GUI.Label (new Rect (15, 10, 320, 73), logoTexture);

				if (GUI.Button (new Rect (25, 100, 100, 30), "Test Level")) {
						Application.LoadLevel ("testlevel"); 
				}
				if (GUI.Button (new Rect (25, 150, 100, 30), "Curve Level")) {
						Application.LoadLevel ("curvelevel"); 
				}

				if (GUI.Button (new Rect (150, 100, 100, 30), "Loop Level")) {
						Application.LoadLevel ("looplevel"); 
				}


				GUI.EndGroup ();
				
				
		}
}
