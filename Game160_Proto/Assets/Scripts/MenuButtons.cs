using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour {

	// Use this for initialization
	public void ComboLock () {

		SceneManager.LoadScene (1);
	
	}
	
	// Update is called once per frame
	public void SpaceShip () {

		SceneManager.LoadScene (2);
	
	}
}
