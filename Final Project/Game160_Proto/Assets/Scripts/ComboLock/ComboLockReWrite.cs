using UnityEngine;
using System.Collections;

public class ComboLockReWrite : MonoBehaviour {

	//Declaring Arrays

	public bool[] Locks;
	public bool[] UnlockedLocks;
	public bool[] LockArray;
	public int[] KeyArray;
	public GameObject[] VisualAid;
	public bool[] Locked;

	// Declaring everything else needed
	int Key;
	int X;
	public int AmountOfLocks = 0;

	int KeysUnlocked;

	ArduinoInput ArdInp;

	void Awake () {
		//Getting input for the controller
		ArdInp = gameObject.GetComponent<ArduinoInput> ();
		//Generating the locks
		for (int i = 0; i < Locks.Length; i++) {
			if (AmountOfLocks <= 3) {
				int RandomNumber = Random.Range (0, 100);
				if (RandomNumber < 50) {
					LockArray [i] = true;
					AmountOfLocks++;
				}
			} 
		}
		//Generating the keys needed
		for (int z = 0; z < KeyArray.Length; z++) {
			KeyArray [z] = Random.Range (0, 7);
		}

	}

	void FixedUpdate () {
		//Each time a key is activated, runs some stuff
		if (Input.GetKeyDown (KeyCode.Y) || ArdInp.Switch1 == true) {
			//Number of the key
			X = 0;
			//Checks to see if its locked or not
			if (Locked [X] == false) {
				// Toggles the lock state
				Locks [X] = !Locks [X];
				//Changes the colour (explained later)
				ChangeColour ();
				//Runs the lock check
				LockCheck ();
			}
		}
		//All of these are the same as above, just for different inputs
		if (Input.GetKeyDown (KeyCode.U) || ArdInp.Switch2 == true) {
			X = 1;
			if (Locked [X] == false) {
				Locks [X] = !Locks [X];
				ChangeColour ();
				LockCheck ();
			}
		}
		if (Input.GetKeyDown (KeyCode.I) || ArdInp.Switch3 == true) {
			X = 2;
			if (Locked [X] == false) {
				Locks [X] = !Locks [X];
				ChangeColour ();
				LockCheck ();
			}
		}
		if (Input.GetKeyDown (KeyCode.O) || ArdInp.Switch4 == true) {
			X = 3;
			if (Locked [X] == false) {
				Locks [X] = !Locks [X];
				ChangeColour ();
				LockCheck ();
			}
		}
		if (Input.GetKeyDown (KeyCode.H) || ArdInp.Switch5 == true) {
			X = 4;
			if (Locked [X] == false) {
				Locks [X] = !Locks [X];
				ChangeColour ();
				LockCheck ();
			}
		}
		if (Input.GetKeyDown (KeyCode.J) || ArdInp.Switch6 == true) {
			X = 5;
			if (Locked [X] == false) {
				Locks [X] = !Locks [X];
				ChangeColour ();
				LockCheck ();
			}
		}
		if (Input.GetKeyDown (KeyCode.K) || ArdInp.Switch7 == true) {
			X = 6;
			if (Locked [X] == false) {
				Locks [X] = !Locks [X];
				ChangeColour ();
				LockCheck ();
			}
		}
		if (Input.GetKeyDown (KeyCode.L) || ArdInp.Switch8 == true) {
			X = 7;
			if (Locked [X] == false) {
				Locks [X] = !Locks [X];
				ChangeColour ();
				LockCheck ();
			}
		}

	}

	public void LockCheck () {
		//Seeing if the key fits the lock
		if (Locks [X] == true) {
			foreach (int Key in KeyArray) {
				if (Key == X) {
					Debug.LogWarning ("Key has been found");
					KeysUnlocked++;
					Locked [X] = true;
					//If all keys are found, goes straight back to the menu
					if (KeysUnlocked == AmountOfLocks) {
						gameObject.GetComponent<ReturnToMenu> ().MainMenu ();
					}
				}
			}
		}
	}

	public void ChangeColour (){
		//Swaps between the two colours
		VisualAid [X].GetComponent<LockActive> ().Active = !VisualAid [X].GetComponent<LockActive> ().Active;
	}
}
