using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(CircleCollider2D))]

public class Brush : MonoBehaviour {

	private Vector2 offset, pos;
	public Canvas myCanvas;
	public GameObject sujeira;
	//Texture2D texture = new Texture2D(128, 128);

	void Start(){
		//GetComponent<Renderer>().material.mainTexture = texture;
	}
	void OnMouseDown() {

		offset = gameObject.transform.position;
	}

	void OnMouseDrag()
	{
		RectTransformUtility.ScreenPointToLocalPointInRectangle (myCanvas.transform as 
			RectTransform, Input.mousePosition, myCanvas.worldCamera, out pos);
		
		transform.position = myCanvas.transform.TransformPoint (pos);
	}

	void OnTriggerStay2D(Collider2D coll){
		if (coll.gameObject.CompareTag ("dirt")) {
			StartCoroutine (limparSujeira (1f));
			/*float sujeira = coll.GetComponent<CanvasGroup> ().alpha;
			for (float tempoFalta = 10f; tempoFalta > 0; tempoFalta -= 2.5f) {
				StartCoroutine (limparSujeira (1f));
				sujeira -= 2.5f;
			}*/
			/*if (sujeira > 0) {
				yield return StartCoroutine (limparSujeira (4f));
			}*/
			/*for (int y = 0; y < texture.height; y++) {
				for (int x = 0; x < texture.width; x++) {
					Color color = ((x & y) != 0 ? Color.white : Color.gray);
					texture.SetPixel (x, y, color);
				}
			}
			texture.Apply ();*/
		}
	}
	private IEnumerator limparSujeira(float determinadoTempo){
			if (sujeira.GetComponent<CanvasGroup> ().alpha > 0f) {
			sujeira.GetComponent<CanvasGroup> ().alpha -= 2.5f;
		yield return new WaitForSeconds (determinadoTempo);
			}

	}
}