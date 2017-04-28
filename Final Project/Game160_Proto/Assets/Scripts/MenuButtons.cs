using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour {

	public void ComboLock () {
		//Loads the second scene in the build order
		SceneManager.LoadScene (1);	
	}

	public void SpaceShip () {
		//Does the 3rd scene
		SceneManager.LoadScene (2);	
	}
}
