using UnityEngine;
using System.Collections;

public class Resource : MonoBehaviour {

	public bool DoorOpen = false;

	void Awake () {
		DoorOpen = false;
	}

	void OnTriggerEnter (Collider other) {	

		if (DoorOpen == true) {
			Destroy (gameObject,1);
		}
	}

	void Update () {
		if (Input.GetKeyDown (KeyCode.Y)) {
			DoorOpen = !DoorOpen;
		}

		if (gameObject == null) {
			GameObject.Find ("GameController").GetComponent<ReturnToMenu> ().MainMenu ();
		}
	}
}
