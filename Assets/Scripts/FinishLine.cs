﻿using UnityEngine;
using System.Collections;

public class FinishLine : MonoBehaviour
{

		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{
	
		}

		void OnTriggerEnter (Collider other)
		{
				PenguinController.RaceFinished ();
				Debug.Log ("Finished!");
		}
}
