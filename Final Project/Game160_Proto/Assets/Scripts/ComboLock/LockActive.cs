using UnityEngine;
using System.Collections;
using UnityEngine.Rendering;

public class LockActive : MonoBehaviour {

	//Setting variables
	Material Colour;
	public bool Active = false;
	public Renderer rend;

	void Awake () {
		//Gets the renderer component of the object this is attached too.
		rend = GetComponent<Renderer>();
		//Sets the renderer to be active
		rend.enabled = true;
	}

	void Update () {

	//Setting the colours
		if (Active == true) {
			rend.material.color = Color.green;
		} else if (Active == false) {
			rend.material.color = Color.red;
		}
	}
}
