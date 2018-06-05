using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(AudioSource))]
public class AudioSequence : MonoBehaviour {
	public AudioClip[] auds;

	private bool playNow = false;
	private int count = 0;
	public AudioClip audio1;
	public AudioClip audio2;
	public AudioClip audio3;
	public AudioClip audio4;
	public AudioSource audio;
	public GameObject imagem1;
	public GameObject imagem2;
	public GameObject imagem3;
	public GameObject texto1;
	public GameObject texto2;

	static public bool elaFalando = false;

	void Start () {
		StartCoroutine (playsound ());
	}

	IEnumerator playsound(){
		audio.clip = audio1;
		audio.Play ();
		yield return new WaitForSeconds (audio.clip.length);

		yield return new WaitForSeconds (0.15f);

		audio.clip = audio2;
		audio.Play ();
		yield return new WaitForSeconds (audio.clip.length);

		yield return new WaitForSeconds (0.15f);

		imagem1.SetActive (false);
		imagem2.SetActive (false);
		texto1.SetActive (false);

		elaFalando = true;

		imagem3.SetActive (true);
		texto2.SetActive (true);

		audio.clip = audio3;
		audio.Play ();
		yield return new WaitForSeconds (audio.clip.length);

		yield return new WaitForSeconds (0.15f);

		audio.clip = audio4;
		audio.Play ();
		yield return new WaitForSeconds (audio.clip.length);

		yield return new WaitForSeconds (0.5f);

		UnityEngine.SceneManagement.SceneManager.LoadScene (2);
	}
}
