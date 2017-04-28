using UnityEngine;
using System.Collections;
using System.IO.Ports;

public class ArduinoInput : MonoBehaviour {

	//Setting the serial port and the baud rate
	SerialPort serial = new SerialPort ("COM4", 9600);

	//Setting booleans to be used in other scripts
	public bool Switch1 = false;
	public bool Switch2 = false;
	public bool Switch3 = false;
	public bool Switch4 = false;
	public bool Switch5 = false;
	public bool Switch6 = false;
	public bool Switch7 = false;
	public bool Switch8 = false;

	//Countdown to prevent overloading
	float Countdown;
	public float CountdownMax;	

	void Awake () {
		//Opening the serial port
		serial.Open ();
		serial.ReadTimeout = 1;

	}

	void Update () {
		//If its open...
		if (serial.IsOpen) {
			try {
				//Basic countdown script to read the input
			Countdown -= Time.deltaTime;
			if (Countdown <= 0) {
				ArduinoInputUpdate ();
				Countdown = CountdownMax;
			}
		   // throw (System.Exception)
			} catch (System.Exception) {

			}

		} else {
			//Just to make sure the port it always open
			serial.Open();
		}
		
	}
		

	void ArduinoInputUpdate () {		

		string ArduinoLine = serial.ReadLine (); // Reads the line of inputs from the arduino
		string[] Inputs = ArduinoLine.Split (','); // Splits the line into multiple strings for an array

		//Setting the bools that were created earlier.
		if (Inputs [0] == "1") {
			Switch1 = true;
		} else {
			Switch1 = false;
		}

		if (Inputs [1] == "1") {
			Switch2 = true;
		} else {
			Switch2 = false;
		}

		if (Inputs [2] == "1") {
			Switch3 = true;
		} else {
			Switch3 = false;
		}

		if (Inputs [3] == "1") {
			Switch4 = true;
		} else {
			Switch4 = false;
		}

		if (Inputs [4] == "1") {
			Switch5 = true;
		} else {
			Switch5 = false;
		}

		if (Inputs [5] == "1") {
			Switch6 = true;
		} else {
			Switch6 = false;
		}

		if (Inputs [6] == "1") {
			Switch7 = true;
		} else {
			Switch7 = false;
		}

		if (Inputs [7] == "1") {
			Switch8 = true;
		} else {
			Switch8 = false;
		}
	}		
}
