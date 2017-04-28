using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Oxygen : MonoBehaviour {
	//Variables
	public bool DoorOpen;
	public Text text;
	public int OxygenLeft;
	float countdown;
	float countdownmax;
	ArduinoInput ArdInp;

	void Awake () {
		//Finding the input script
		ArdInp = GameObject.FindGameObjectWithTag ("GameController").GetComponent<ArduinoInput> ();
		//Setting some values
		OxygenLeft = 99;
		countdown = 0.25f;
		countdownmax = 0.25f;
	}

	void Update () {
		//Toggling if the door is open
		if (Input.GetKeyDown (KeyCode.Y) || ArdInp.Switch4 == true) {
			DoorOpen = !DoorOpen;
		}

		//Setting some text on the screen
		text.text = "Oxygen Left = " + OxygenLeft;
		//Helping you with your deprivation of oxygen!
		if (DoorOpen == true) {
			countdown -= Time.deltaTime;
			if (countdown <= 0) {
				OxygenLeft -= 5;
				Debug.Log (OxygenLeft);
				countdown = countdownmax;
			}
		}
		//Refills your oxygen when the door is closed
		if (DoorOpen == false && OxygenLeft <= 99) {
			OxygenLeft++;
			Debug.Log (OxygenLeft);
		}
		//Kills you
		if (OxygenLeft <= 0) {
			GameObject.FindGameObjectWithTag ("GameController").GetComponent<ReturnToMenu> ().MainMenu ();
		}
	
	}
}
