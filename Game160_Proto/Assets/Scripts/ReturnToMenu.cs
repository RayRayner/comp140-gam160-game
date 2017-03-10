using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ReturnToMenu : MonoBehaviour {

	void Awake () {
//		Invoke ("MainMenu", 3);
	}

	public void MainMenu () {
		
		SceneManager.LoadScene (0);
	}
}
