﻿using UnityEngine;
using System.Collections;

public class TriggerTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider col)
	{
		if (col.tag == "Player") {
			Debug.Log ("walked on event");
		}
	}
}
