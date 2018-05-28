using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clue : MonoBehaviour {

	private bool canTake = false;
	SceneManager SM;
	public Text clickF;

	void Start () {
		clickF = clickF.GetComponent<Text> ();
	}

	void Update () {

		if (Input.GetKeyDown (KeyCode.F) && canTake) {
			gameObject.GetComponent<SpriteRenderer> ().enabled = false;
			gameObject.GetComponent<BoxCollider2D> ().enabled = false;
			SM.GetComponent<SceneManager> ().clueP.gameObject.SetActive(true);
			clickF.gameObject.SetActive (false);
		}
	}

	public void OnTriggerStay (Collider col){
	
		if (col.gameObject.CompareTag ("Player")) {
			canTake = true;
			clickF.gameObject.SetActive (true);
		}
	}

	public void OnTriggerExit (Collider col) {
		
		if (col.gameObject.CompareTag ("Player")) {
			canTake = false;
			clickF.gameObject.SetActive (false);
		}
	}
}
