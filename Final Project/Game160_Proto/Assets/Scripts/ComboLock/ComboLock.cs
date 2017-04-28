using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/*

	CONTROLS

	Y   U   I   O
 	  G   H   J    K

*/

//
//		OBSELETE SCRIPT. NO COMMENTS!
//

public class ComboLock : MonoBehaviour {

	public bool Lock1;
	public bool Lock2;
	public bool Lock3;
	public bool Lock4;
	public bool Lock5;
	public bool Lock6;
	public bool Lock7;
	public bool Lock8;

	public int[] KeyArray;

	public int Key1;
	public int Key2;
	public int Key3;

	public bool Unlock1;
	public bool Unlock2;
	public bool Unlock3;

	public int AmountOfLocks = 0;

	public bool[] LockArray;

	public GameObject[] VisualAid; 

	public GameObject Canvas;

	public int X;


	// Use this for initialization
	void Awake () {

		LockArray = new bool[8];

		LockArray [0] = Lock1;
		LockArray [1] = Lock2;
		LockArray [2] = Lock3;
		LockArray [3] = Lock4;
		LockArray [4] = Lock5;
		LockArray [5] = Lock6;
		LockArray [6] = Lock7;
		LockArray [7] = Lock8;

		for (int i = 0; i < 8; i++) {
				if (AmountOfLocks < 3) {
					int RandomNumber = Random.Range (0, 100);
					if (RandomNumber < 50) {
						LockArray [i] = true;
						Debug.Log (LockArray [i] + "" + i);
						AmountOfLocks++;
					} else {
						Debug.Log (LockArray [i] + "" + i);
					}

			}
		}

		KeyArray = new int[3];

		KeyArray [0] = Key1;
		KeyArray [1] = Key2;
		KeyArray [2] = Key3;

		for (int z = 0; z < 3; z++) {

			Key1 = Random.Range (0, 7);
			Key2 = Random.Range (0, 7);
			Key3 = Random.Range (0, 7);

		}

	}

	// Update is called once per frame
	void Update ()
	{

		if (Unlock1 == true && Unlock2 == true && Unlock3 == true) {
			Canvas.SetActive (true);
			gameObject.GetComponent<ReturnToMenu> ().MainMenu ();
		}

		if (Input.GetKeyUp (KeyCode.Y)) {
			X = 0;
			Lock1 = true;
			ChangeColour ();
			LockCheck ();
		}
		if (Input.GetKeyUp (KeyCode.U)) {
			X = 1;
			Lock2 = true;
			ChangeColour ();
			LockCheck ();
		}
		if (Input.GetKeyUp (KeyCode.I)) {
			X = 2;
			Lock3 = true;
			ChangeColour ();
			LockCheck ();
		}
		if (Input.GetKeyUp (KeyCode.O)) {
			X = 3;
			Lock4 = true;
			ChangeColour ();
			LockCheck ();
		}
		if (Input.GetKeyUp (KeyCode.H)) {
			X = 4;
			Lock5 = true;
			ChangeColour ();
			LockCheck ();
		}
		if (Input.GetKeyUp (KeyCode.J)) {
			X = 5;
			Lock6 = true;
			ChangeColour ();
			LockCheck ();
		}
		if (Input.GetKeyUp (KeyCode.K)) {
			X = 6;
			Lock7 = true;
			ChangeColour ();
			LockCheck ();
		}
		if (Input.GetKeyUp (KeyCode.L)) {
			X = 7;
			Lock8 = true;
			ChangeColour ();
			LockCheck ();
		}



	}

	public void LockCheck () {

		if (LockArray [X] == true) {
			Debug.Log (X + " is true");
			foreach (int Key in KeyArray) {
				if (Key == X) {
					Debug.Log ("Correct Key");
				} else {
					Debug.Log ("Wrong Key");
				}
			}
		} else {
			Debug.Log (X + " is false");
		}

	}

	public void ChangeColour (){
		VisualAid [X].GetComponent<LockActive> ().Active = !VisualAid [X].GetComponent<LockActive> ().Active;
	}

	public void ToggleLock() {

	}
}