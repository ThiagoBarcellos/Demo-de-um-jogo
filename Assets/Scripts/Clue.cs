using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clue : MonoBehaviour {

	private bool canTake = false;
	SceneManager SM;
	public Text clickF;
	private bool jaPegou = false;
	public GameObject clue;
	static public bool pegouFoto = false;

	void Start () {
		clickF = clickF.GetComponent<Text> ();
	}

	void Update () {

		if (Input.GetKeyDown (KeyCode.F) && canTake && jaPegou == false) {
			jaPegou = true;
			pegouFoto = true;
			clickF.gameObject.SetActive (false);
			clue.SetActive (false);
		}
	}

	public void OnTriggerStay (Collider col){
	
		if (jaPegou == false) {
			if (col.gameObject.CompareTag ("Player") && jaPegou == false) {
				canTake = true;
				clickF.gameObject.SetActive (true);
			}
		}
	}

	public void OnTriggerExit (Collider col) {
		
		if (col.gameObject.CompareTag ("Player")) {
			canTake = false;
			clickF.gameObject.SetActive (false);
		}
	}
}
