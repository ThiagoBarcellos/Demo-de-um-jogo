﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;

[RequireComponent(typeof(AudioSource))]

public class MenuScene : MonoBehaviour {

	/*public Button play;
	public AudioClip[] auds;

	private bool playNow = false;
	private int count = 0;

	void Start () {
		play = play.GetComponent<Button> ();
		play.onClick.AddListener (OnMouseClick);

		auds = new AudioClip[] {
			(AudioClip)Resources.Load ("Sounds/audio 2.mp3"),
			(AudioClip)Resources.Load ("Sounds/audio 3.mp3"),
			(AudioClip)Resources.Load ("Sounds/audio 4.mp3")};
	}
*/
	public void OnMouseClick () {
		//Debug.Log ("disgraça");
		UnityEngine.SceneManagement.SceneManager.LoadScene (1);
	}

	/*void playSounds () {
		if(!audio.isPlaying && count < auds.Length){
			audio.clip = auds[count];
			audio.Play();
			count = count + 1;
		}
		if(count == auds.Length)
			count = 0;
	}*/
}

