﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VoltarMenu : MonoBehaviour {


	void Update () {

		if (Input.GetKeyDown(KeyCode.Space)) {
			UnityEngine.SceneManagement.SceneManager.LoadScene (0);
		}
	}
}
