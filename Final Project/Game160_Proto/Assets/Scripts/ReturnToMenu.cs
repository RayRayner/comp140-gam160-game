using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ReturnToMenu : MonoBehaviour {

	public void MainMenu () {
		//Loads the main menu
		SceneManager.LoadScene (0);
	}
}
