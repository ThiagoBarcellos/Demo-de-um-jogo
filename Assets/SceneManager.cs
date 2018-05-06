using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneManager : MonoBehaviour {

	public GameObject menu;
	static bool isPaused = false;

	public GameObject panelCP, panelSC, panelCont, panelEmail;
	public Button contact, email, exit1, exit2;
	bool isActiveCP = false;
	bool isActiveSC = false;

	void Start () {
		menu.SetActive (false);
		panelCP.SetActive (false);
		panelSC.SetActive (false);
		panelCont.SetActive (false);
		panelEmail.SetActive (false);

		/*contact = contact.GetComponent<Button> ();
		email = email.GetComponent<Button> ();
		exit1 = exit1.GetComponent<Button> ();
		exit2 = exit2.GetComponent<Button> ();

		contact.onClick.AddListener (onContactsClick);
		email.onClick.AddListener (onEmailClick);
		exit1.onClick.AddListener (onExitCPClick);
		exit2.onClick.AddListener (onExitCPClick);*/

	}

	void Update ()
	{
		CPSC ();

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

	void CPSC () {
		//turn on&off the cellphone screen
		if (Input.GetKeyDown (KeyCode.E)) {
			if (isActiveCP == false) {
				panelCP.SetActive (true);
				isActiveCP = true;
				Cursor.visible = true;
			} else {
				panelCP.SetActive (false);
				isActiveCP = false;
				Cursor.visible = false;
			}
		}
		//turn on&off the suitcase screen
		if (Input.GetKeyDown (KeyCode.Q)) {
			if (isActiveSC == false) {
				panelSC.SetActive (true);
				isActiveSC = true;
				Cursor.visible = true;
			} else { 
				panelSC.SetActive (false);
				isActiveSC = false;
				Cursor.visible = false;
			}
		}
	}

	//still not working
	/*void onContactsClick () {
		//this is inside "Cellphone". Go to Contacts screen.
		panelCont.SetActive (true);
	}

	void onEmailClick () {
		//this is inside "Cellphone". Go to E-mail screen.
		panelEmail.SetActive (true);
	}

	void onExitCPClick () {
		//this is inside "Cellphone". Exit Contacts&Email screens.
		panelCont.SetActive (false);
		panelEmail.SetActive (false);
	}*/
}