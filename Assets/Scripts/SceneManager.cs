using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;

public class SceneManager : MonoBehaviour {

	public GameObject menu;
	static bool isPaused = false;
  

	public GameObject panelCP, panelSC, panelCont, panelEmail;
	public Button contact, email, exit1, exit2, play, menuB, Pplay;
	bool isActiveCP = false;
	bool isActiveSC = false;

	void Start () {

        menu.SetActive (false);
		panelCP.SetActive (false);
		panelSC.SetActive (false);
		panelCont.SetActive (false);
		panelEmail.SetActive (false);

		contact = contact.GetComponent<Button> ();
		email = email.GetComponent<Button> ();
		exit1 = exit1.GetComponent<Button> ();
		exit2 = exit2.GetComponent<Button> ();
		play = play.GetComponent<Button> ();
		menuB = menuB.GetComponent<Button> ();
		Pplay = Pplay.GetComponent<Button> ();

		contact.onClick.AddListener (onContactsClick);
		email.onClick.AddListener (onEmailClick);
		exit1.onClick.AddListener (onExitCPClick);
		exit2.onClick.AddListener (onExitCPClick);
		play.onClick.AddListener (onPlayClick);
		menuB.onClick.AddListener (onMenuClick);
		Pplay.onClick.AddListener (onPrincipalPlayClick);

       

    }

	void Update ()
	{
		CPSC ();

        

        if (Input.GetKeyDown (KeyCode.Escape)) {
			if (isPaused == false) {
				Time.timeScale = 0f;
				menu.SetActive (true);
				isPaused = true;
                

            } else {
				Time.timeScale = 1f;
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
                panelSC.SetActive(false);
                isActiveCP = true;
                isActiveSC = false;
                
            } else {
				panelCP.SetActive (false);
				isActiveCP = false;
                
            }
		}
		//turn on&off the suitcase screen
		if (Input.GetKeyDown (KeyCode.Q)) {
			
			if (isActiveSC == false) {
				panelSC.SetActive (true);
                panelCP.SetActive(false);
                isActiveSC = true;
                isActiveCP = false;

            } else { 
				panelSC.SetActive (false);
				isActiveSC = false;

			}
		}
	}

	public void onPlayClick () {
		//works just as fine as clicking Esc
		menu.SetActive (false);
	}

	public void onMenuClick (){
        //go back to menu. does not save your progress (yet)
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }

	public void onContactsClick () {
		//this is inside "Cellphone". Go to Contacts screen.
		panelCont.SetActive (true);
	}

	public void onEmailClick () {
		//this is inside "Cellphone". Go to E-mail screen.
		panelEmail.SetActive (true);
	}

	public void onExitCPClick () {
		//this is inside "Cellphone". Exit Contacts&Email screens.
		panelCont.SetActive (false);
		panelEmail.SetActive (false);
	}

    public void onPrincipalPlayClick()
    {
        //play button inside Menu screen. it is in another scene.
        
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);

    }

   
}