<<<<<<< .mine
﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Oxygen : MonoBehaviour {

	public bool DoorOpen;
	public Text text;
	public int OxygenLeft;

	float countdown;
	float countdownmax;

	void Awake () {
		OxygenLeft = 99;
		countdown = 0.25f;
		countdownmax = 0.25f;
	}

	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.Y)) {
			DoorOpen = !DoorOpen;
		}

		text.text = "Oxygen Left = " + OxygenLeft;

		if (DoorOpen == true) {
			countdown -= Time.deltaTime;
			if (countdown <= 0) {
				OxygenLeft -= 5;
				Debug.Log (OxygenLeft);
				countdown = countdownmax;
			}
		}
		if (DoorOpen == false && OxygenLeft <= 99) {
			OxygenLeft++;
			Debug.Log (OxygenLeft);
		}

		if (OxygenLeft <= 0) {
			GameObject.FindGameObjectWithTag ("GameController").GetComponent<ReturnToMenu> ().MainMenu ();
		}
	
	}
}
||||||| .r0
=======
﻿using UnityEngine;
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
>>>>>>> .r17
