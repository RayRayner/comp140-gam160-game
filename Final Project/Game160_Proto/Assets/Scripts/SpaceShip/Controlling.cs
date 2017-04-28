using UnityEngine;
using System.Collections;

public class Controlling : MonoBehaviour {

	//Setting variables
	NavMeshAgent nma;
	public bool DoorOpen = false;
	bool SpeedIncrease;
	ReturnToMenu Menu;
	ArduinoInput ArdInp;
	public int ResourceCount;

	void Start () {
		//Finding all the scripts
		ArdInp = GameObject.FindGameObjectWithTag ("GameController").GetComponent<ArduinoInput> ();
		nma = GetComponent<NavMeshAgent> ();
		Menu = GameObject.FindGameObjectWithTag ("GameController").GetComponent<ReturnToMenu> ();
	}
	
	// Update is called once per frame
	void Update () {
		//Seeing if the player wants to increase their speed
		if (Input.GetKeyDown (KeyCode.U) || ArdInp.Switch2 == true) {
			SpeedIncrease = !SpeedIncrease;
		}
		//Toggles between 2 set values for player speed
		if (SpeedIncrease == true) {
			nma.speed = 10f;
		} else if (SpeedIncrease == false) {
			nma.speed = 3.5f;
		}
		//Opening the door
		if (Input.GetKeyDown (KeyCode.Y) || ArdInp.Switch4 == true) {			
			if (DoorOpen == false) {
				Debug.Log ("Door Unlocked");
				DoorOpen = true;
			} else  if (DoorOpen == true){
				Debug.Log ("Door Closed");
				DoorOpen = false;					
			}
		}
		//Checks to see if wincon has been met
		if (GameObject.FindGameObjectWithTag ("Resource") == null && ResourceCount > 3) {
			Menu.MainMenu ();
		} else {
			//If it hasnt, goes for the next objective
			nma.SetDestination (GameObject.FindGameObjectWithTag ("Resource").transform.position);
		}
	}
}
