using UnityEngine;
using System.Collections;

public class ChangeShader : MonoBehaviour {
	public Material original;
	public Material newColor; 
	// Use this for initialization
	Renderer rend;
	void Start () {
		rend = GetComponent<Renderer>();
	}

	void OnTriggerStay (Collider col)
	{
			if (col.gameObject.name == "FPSController") {
			rend.material = newColor;
			}

	}

	void OnTriggerExit (Collider col)
	{
		if (col.gameObject.name == "FPSController") {
			rend.material = original;
		}
	}
}
