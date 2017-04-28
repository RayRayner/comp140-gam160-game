using UnityEngine;
using System.Collections;

public class Resource : MonoBehaviour {
	//Saying the door doesnt start open
	public bool DoorOpen = false;
	ArduinoInput ArdInp;

	void Awake () {
		//Double checking the door doesnt start open
		DoorOpen = false;

		ArdInp = GameObject.FindGameObjectWithTag ("GameController").GetComponent<ArduinoInput> ();
	}

	void OnTriggerEnter (Collider other) {	
		//Destroys the object if the door is open and its touching me
		if (DoorOpen == true) {
			Destroy (gameObject,1);
		}
	}

	void Update () {
		//Toggles the door state
		if (Input.GetKeyDown (KeyCode.Y) || ArdInp.Switch4 == true ) {
			DoorOpen = !DoorOpen;
		}

		//If I dont exist, returns to the main menu
		if (gameObject == null) {
			GameObject.Find ("GameController").GetComponent<ReturnToMenu> ().MainMenu ();
		}
	}
}
