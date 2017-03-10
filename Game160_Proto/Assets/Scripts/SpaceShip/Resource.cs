using UnityEngine;
using System.Collections;

public class Resource : MonoBehaviour {

	public bool DoorOpen = false;

	void OnTriggerEnter (Collider other) {

		if (DoorOpen == true) {
			Destroy (gameObject);
		}
	}
}
