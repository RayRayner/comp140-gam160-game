using UnityEngine;
using System.Collections;

public class Controlling : MonoBehaviour {

	NavMeshAgent nma;

	public bool DoorOpen = false;

	Resource Res;
	Oxygen Oxy;
	ReturnToMenu Menu;


	// Use this for initialization
	void Start () {
	
		Oxy = GetComponent<Oxygen> ();
		Res = GameObject.FindGameObjectWithTag ("Resource").GetComponent<Resource> ();
		nma = GetComponent<NavMeshAgent> ();
		Menu = GameObject.FindGameObjectWithTag ("GameController").GetComponent<ReturnToMenu> ();
	}
	
	// Update is called once per frame
	void Update () {

		nma.SetDestination (GameObject.FindGameObjectWithTag ("Resource").transform.position);

		if (Input.GetKeyDown (KeyCode.Y)) {			
			if (DoorOpen == false) {
				Debug.Log ("Door Unlocked");
				DoorOpen = true;
				Res.DoorOpen = true;
				Oxy.DoorOpen = true;
			} else  if (DoorOpen == true){
					Debug.Log ("Door Closed");
					DoorOpen = false;
				Res.DoorOpen = false;
				Oxy.DoorOpen = false;
			}
		}

		if (GameObject.FindGameObjectWithTag ("Resource") != null) {
			Menu.MainMenu ();
		}
	}
}
