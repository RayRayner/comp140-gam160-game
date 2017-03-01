using UnityEngine;
using System.Collections;

/*

		CONTROLS

				Y   U   I   O
		 		  G   H   J    K

*/

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

	public int AmountOfLocks = 0;

	public bool[] LockArray;

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

			int RandomNumber = Random.Range (0, 100);
			if (RandomNumber < 50) {
				LockArray [i] = true;
				Debug.Log (LockArray [i] + "" + i);
				AmountOfLocks++;
			} else {
				Debug.Log (LockArray [i] + "" + i);
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
	void Update () {
		
		if (Input.GetKeyDown (KeyCode.Y)) {
			if (LockArray [0] == true) {
				Debug.Log ("Lock 1 Active");
				if (Key1 == 0 || Key2 == 0 || Key3 == 0) {
					Debug.Log ("Key 1 Active");
				}
			} else {
				Debug.Log ("Lock 1 InActive");
			}
		}

		if (Input.GetKeyDown (KeyCode.U)) {
			if (LockArray [1] == true) {
				Debug.Log ("Lock 2 Active");
				if (Key1 == 1 || Key2 == 1 || Key3 == 1) {
					Debug.Log ("Key 2 Active");
				}
			} else {
				Debug.Log ("Lock 2 InActive");
			}
		}

		if (Input.GetKeyDown (KeyCode.I)) {
			if (LockArray [2] == true) {
				Debug.Log ("Lock 3 Active");
				if (Key1 == 2 || Key2 == 2 || Key3 == 2) {
					Debug.Log ("Key 3 Active");
				}
			} else {
				Debug.Log ("Lock 3 InActive");
			}
		}

		if (Input.GetKeyDown (KeyCode.O)) {
			if (LockArray [3] == true) {
				Debug.Log ("Lock 4 Active");
				if (Key1 == 3 || Key2 == 3 || Key3 == 3) {
					Debug.Log ("Key 4 Active");
				}
			} else {
				Debug.Log ("Lock 4 InActive");
			}
		}

		if (Input.GetKeyDown (KeyCode.H)) {
			if (LockArray [4] == true) {
				Debug.Log ("Lock 5 Active");
				if (Key1 == 4 || Key2 == 4 || Key3 == 4) {
					Debug.Log ("Key 5 Active");
				}
			} else {
				Debug.Log ("Lock 5 InActive");
			}
		}

		if (Input.GetKeyDown (KeyCode.J)) {
			if (LockArray [5] == true) {
				Debug.Log ("Lock 6 Active");
				if (Key1 == 5 || Key2 == 5 || Key3 == 5) {
					Debug.Log ("Key 6 Active");
				}
			} else {
				Debug.Log ("Lock 6 InActive");
			}
		}

		if (Input.GetKeyDown (KeyCode.K)) {
			if (LockArray [6] == true) {
				Debug.Log ("Lock 7 Active");
				if (Key1 == 6 || Key2 == 6 || Key3 == 6) {
					Debug.Log ("Key 7 Active");
				}
			} else {
				Debug.Log ("Lock 7 InActive");
			}
		}

		if (Input.GetKeyDown (KeyCode.L)) {
			if (LockArray [7] == true) {
				Debug.Log ("Lock 8 Active");
				if (Key1 == 7 || Key2 == 7 || Key3 == 7) {
					Debug.Log ("Key 8 Active");
				}
			} else {
				Debug.Log ("Lock 8 InActive");
			}
		}

	}
}
