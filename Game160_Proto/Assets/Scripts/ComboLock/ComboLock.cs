using UnityEngine;
using System.Collections;
using System.Collections.Generic;

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

	public bool Unlock1;
	public bool Unlock2;
	public bool Unlock3;

	public int AmountOfLocks = 0;

	public bool[] LockArray;

	public GameObject[] VisualAid; 

	public GameObject Canvas;


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

		for (int q = 0; q < 8; q++) {



		}

	}

	// Update is called once per frame
	void Update ()
	{

		if (Unlock1 == true && Unlock2 == true && Unlock3 == true) {
			Canvas.SetActive (true);

			gameObject.GetComponent<ReturnToMenu> ().MainMenu ();
		}

		if (Input.GetKeyDown (KeyCode.Y)) {
//			if (LockArray [0] == true) {
				if (Key1 == 0 || Key2 == 0 || Key3 == 0) {
					if (Unlock1 == false && Unlock2 == false && Unlock3 == false) {
						Unlock1 = true;
						VisualAid [0].GetComponent<LockActive> ().Active = true;
					} else if (Unlock1 == true && Unlock2 == false && Unlock3 == false) {
						Unlock2 = true;
						VisualAid [0].GetComponent<LockActive> ().Active = true;
					} else if (Unlock1 == true && Unlock2 == true && Unlock3 == false) {
						Unlock3 = true;
						VisualAid [0].GetComponent<LockActive> ().Active = true;
//					}
				} else {
					VisualAid [0].GetComponent<LockActive> ().Active = false;
				}
			}
		}

		if (Input.GetKeyDown (KeyCode.U)) {
//			if (LockArray [1] == true) {
				if (Key1 == 1 || Key2 == 1 || Key3 == 1) {
					if (Unlock1 == false && Unlock2 == false && Unlock3 == false) {
						Unlock1 = true;
						VisualAid [1].GetComponent<LockActive> ().Active = true;
					} else if (Unlock1 == true && Unlock2 == false && Unlock3 == false) {
						Unlock2 = true;
						VisualAid [1].GetComponent<LockActive> ().Active = true;
					} else if (Unlock1 == true && Unlock2 == true && Unlock3 == false) {
						Unlock3 = true;
						VisualAid [1].GetComponent<LockActive> ().Active = true;
					}
//				}
			} else {
				VisualAid [1].GetComponent<LockActive> ().Active = false;
			}	
		}


		if (Input.GetKeyDown (KeyCode.I)) {
//			if (LockArray [2] == true) {
				if (Key1 == 2 || Key2 == 2 || Key3 == 2) {
					if (Unlock1 == false && Unlock2 == false && Unlock3 == false) {
						Unlock1 = true;
						VisualAid [2].GetComponent<LockActive> ().Active = true;
					} else if (Unlock1 == true && Unlock2 == false && Unlock3 == false) {
						Unlock2 = true;
						VisualAid [2].GetComponent<LockActive> ().Active = true;
					} else if (Unlock1 == true && Unlock2 == true && Unlock3 == false) {
						Unlock3 = true;
						VisualAid [2].GetComponent<LockActive> ().Active = true;
					}
//				}
			} else {
				VisualAid [2].GetComponent<LockActive> ().Active = false;
			}
		}


		if (Input.GetKeyDown (KeyCode.O)) {
//			if (LockArray [3] == true) {
				if (Key1 == 3 || Key2 == 3 || Key3 == 3) {
					if (Unlock1 == false && Unlock2 == false && Unlock3 == false) {
						Unlock1 = true;
						VisualAid [3].GetComponent<LockActive> ().Active = true;
					} else if (Unlock1 == true && Unlock2 == false && Unlock3 == false) {
						Unlock2 = true;
						VisualAid [3].GetComponent<LockActive> ().Active = true;
					} else if (Unlock1 == true && Unlock2 == true && Unlock3 == false) {
						Unlock3 = true;
						VisualAid [3].GetComponent<LockActive> ().Active = true;
					}
//				}
			} else {
				VisualAid [3].GetComponent<LockActive> ().Active = false;
			}
		}


		if (Input.GetKeyDown (KeyCode.H)) {
//			if (LockArray [4] == true) {
				if (Key1 == 4 || Key2 == 4 || Key3 == 4) {
					if (Unlock1 == false && Unlock2 == false && Unlock3 == false) {
						Unlock1 = true;
						VisualAid [4].GetComponent<LockActive> ().Active = true;
					} else if (Unlock1 == true && Unlock2 == false && Unlock3 == false) {
						Unlock2 = true;
						VisualAid [4].GetComponent<LockActive> ().Active = true;
					} else if (Unlock1 == true && Unlock2 == true && Unlock3 == false) {
						Unlock3 = true;
						VisualAid [4].GetComponent<LockActive> ().Active = true;
					}
//				}
			} else {
				VisualAid [4].GetComponent<LockActive> ().Active = false;
			}
		}


		if (Input.GetKeyDown (KeyCode.J)) {
//			if (LockArray [5] == true) {
				if (Key1 == 5 || Key2 == 5 || Key3 == 5) {
					if (Unlock1 == false && Unlock2 == false && Unlock3 == false) {
						Unlock1 = true;
						VisualAid [5].GetComponent<LockActive> ().Active = true;
					} else if (Unlock1 == true && Unlock2 == false && Unlock3 == false) {
						Unlock2 = true;
						VisualAid [5].GetComponent<LockActive> ().Active = true;
					} else if (Unlock1 == true && Unlock2 == true && Unlock3 == false) {
						Unlock3 = true;
						VisualAid [5].GetComponent<LockActive> ().Active = true;
					}
//				}
			} else {
				VisualAid [5].GetComponent<LockActive> ().Active = false;
			}
		}


		if (Input.GetKeyDown (KeyCode.K)) {
//			if (LockArray [6] == true) {
				if (Key1 == 6 || Key2 == 6 || Key3 == 6) {
					if (Unlock1 == false && Unlock2 == false && Unlock3 == false) {
						Unlock1 = true;
						VisualAid [6].GetComponent<LockActive> ().Active = true;
					} else if (Unlock1 == true && Unlock2 == false && Unlock3 == false) {
						Unlock2 = true;
						VisualAid [6].GetComponent<LockActive> ().Active = true;
					} else if (Unlock1 == true && Unlock2 == true && Unlock3 == false) {
						Unlock3 = true;
						VisualAid [6].GetComponent<LockActive> ().Active = true;
					}
//				}
			} else {
				VisualAid [6].GetComponent<LockActive> ().Active = false;
			}
		}


		if (Input.GetKeyDown (KeyCode.L)) {
//			if (LockArray [7] == true) {
				if (Key1 == 7 || Key2 == 7 || Key3 == 7) {
					if (Unlock1 == false && Unlock2 == false && Unlock3 == false) {
						Unlock1 = true;
						VisualAid [7].GetComponent<LockActive> ().Active = true;
					} else if (Unlock1 == true && Unlock2 == false && Unlock3 == false) {
						Unlock2 = true;
						VisualAid [7].GetComponent<LockActive> ().Active = true;
					} else if (Unlock1 == true && Unlock2 == true && Unlock3 == false) {
						Unlock3 = true;
						VisualAid [7].GetComponent<LockActive> ().Active = true;
					}
//				}
			} else {
				VisualAid [7].GetComponent<LockActive> ().Active = false;
			}
		}
	}
}