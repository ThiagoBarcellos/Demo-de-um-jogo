using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneManager : MonoBehaviour {

	public GameObject menu;
	static bool isPaused = false;

	// Use this for initialization
	void Start () {
		menu.SetActive (false);
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.Escape)) {
			if (isPaused == false) {
				Time.timeScale = 0;
				menu.SetActive (true);
				isPaused = true;
			} else {
				Time.timeScale = 1;
				menu.SetActive (false);
				isPaused = false;
			}

		}
	}
}