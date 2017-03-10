using UnityEngine;
using System.Collections;
using UnityEngine.Rendering;

public class LockActive : MonoBehaviour {

	Material Colour;
	public bool Active = false;
	public Renderer rend;

	void Awake () {
		rend = GetComponent<Renderer>();
		rend.enabled = true;
	}
	
	// Update is called once per frame
	void Update () {


	
		if (Active == true) {
			rend.material.color = Color.green;
		} else if (Active == false) {
			rend.material.color = Color.red;
		}


	}
}
