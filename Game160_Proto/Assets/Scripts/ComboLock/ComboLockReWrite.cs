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
	Controls Cont;

	int KeysUnlocked;

	void Awake () {

		Cont = gameObject.GetComponent<Controls> ();

		for (int i = 0; i < Locks.Length; i++) {
			if (AmountOfLocks <= 3) {
				int RandomNumber = Random.Range (0, 100);
				if (RandomNumber < 50) {
					LockArray [i] = true;
					AmountOfLocks++;
				}
			} 
		}

		for (int z = 0; z < KeyArray.Length; z++) {
			KeyArray [z] = Random.Range (0, 7);
		}

	}

	void Update () {

		if (Input.GetKeyDown (KeyCode.Y)) {
			X = 0;
			if (Locked [X] == false) {
				Cont.ButtonY = !Cont.ButtonY;
				Locks [X] = !Locks [X];
				ChangeColour ();
				LockCheck ();
			}
		}
		if (Input.GetKeyDown (KeyCode.U)) {
			X = 1;
			if (Locked [X] == false) {
				Cont.ButtonU = !Cont.ButtonU;
				Locks [X] = !Locks [X];
				ChangeColour ();
				LockCheck ();
			}
		}
		if (Input.GetKeyDown (KeyCode.I)) {
			X = 2;
			if (Locked [X] == false) {
				Cont.ButtonI = !Cont.ButtonI;
				Locks [X] = !Locks [X];
				ChangeColour ();
				LockCheck ();
			}
		}
		if (Input.GetKeyDown (KeyCode.O)) {
			X = 3;
			if (Locked [X] == false) {
				Cont.ButtonO = !Cont.ButtonO;
				Locks [X] = !Locks [X];
				ChangeColour ();
				LockCheck ();
			}
		}
		if (Input.GetKeyDown (KeyCode.H)) {
			X = 4;
			if (Locked [X] == false) {
				Cont.ButtonH = !Cont.ButtonH;
				Locks [X] = !Locks [X];
				ChangeColour ();
				LockCheck ();
			}
		}
		if (Input.GetKeyDown (KeyCode.J)) {
			X = 5;
			if (Locked [X] == false) {
				Cont.ButtonJ = !Cont.ButtonJ;
				Locks [X] = !Locks [X];
				ChangeColour ();
				LockCheck ();
			}
		}
		if (Input.GetKeyDown (KeyCode.K)) {
			X = 6;
			if (Locked [X] == false) {
				Cont.ButtonK = !Cont.ButtonK;
				Locks [X] = !Locks [X];
				ChangeColour ();
				LockCheck ();
			}
		}
		if (Input.GetKeyDown (KeyCode.L)) {
			X = 7;
			if (Locked [X] == false) {
				Cont.ButtonL = !Cont.ButtonL;
				Locks [X] = !Locks [X];
				ChangeColour ();
				LockCheck ();
			}
		}

	}

	public void LockCheck () {

		if (Locks [X] == true) {
			foreach (int Key in KeyArray) {
				if (Key == X) {
					Debug.LogWarning ("Key has been found");
					KeysUnlocked++;
					Locked [X] = true;
					if (KeysUnlocked == AmountOfLocks) {
						gameObject.GetComponent<ReturnToMenu> ().MainMenu ();
					}
				}
			}
		}
	}

	public void ChangeColour (){
		VisualAid [X].GetComponent<LockActive> ().Active = !VisualAid [X].GetComponent<LockActive> ().Active;
	}

	public void ToggleLock() {

	}

}
