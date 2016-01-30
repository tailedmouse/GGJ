using UnityEngine;
using System.Collections;

public class PickUpObjectTrial : MonoBehaviour {
	bool pickedUpObject = false; 

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void PickObjectUp()
	{
		if (Input.GetKeyDown(KeyCode.L))
		{
			gameObject.transform.parent = GameObject.Find("FPSController").transform;
			gameObject.transform.localPosition = new Vector3 (1.35F,0.29F,1.52F);
			//pickedUpObject = true;
		}
	}

	void OnTriggerStay(Collider col)
	{
		if (col.gameObject.name == "FPSController"){// && pickedUpObject == false) {
				PickObjectUp();

			//Debug.Log ("Object picked up");
		}
	}
}
