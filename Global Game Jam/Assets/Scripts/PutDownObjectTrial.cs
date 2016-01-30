using UnityEngine;
using System.Collections;

public class PutDownObjectTrial : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerStay (Collider col)
	{
		if (col.gameObject.name == "FPSController") {
			if (Input.GetKey(KeyCode.L))
			{
				GameObject.Find ("PickUpTrial").transform.parent = GameObject.Find("Table").transform;
				GameObject.Find ("PickUpTrial").transform.position = GameObject.Find("Table").transform.position;

				GameObject.Find ("PickUpTrial").transform.localPosition = new Vector3 (0,1.5F,0);
				//GameObject.Find ("PickUpTrial").transform.localScale = new Vector3 (1,1,1);
				Debug.Log ("PutDown");
			}
		}

	}
}
