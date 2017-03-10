using UnityEngine;
using System.Collections;

public class Oxygen : MonoBehaviour {

	public bool DoorOpen;

	public int OxygenLeft;

	void Awake () {
		OxygenLeft = 100;
	}

	// Update is called once per frame
	void Update () {


		if (DoorOpen == true) {
			OxygenLeft -= 1;
			Debug.Log (OxygenLeft);
		}
		if (DoorOpen == false && OxygenLeft <= 100) {
			OxygenLeft++;
			Debug.Log (OxygenLeft);
		}

		if (OxygenLeft <= 0) {
			Destroy (gameObject,1);
		}
	
	}
}
