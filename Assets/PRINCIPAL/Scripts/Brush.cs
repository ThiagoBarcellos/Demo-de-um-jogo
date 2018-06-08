using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(CircleCollider2D))]

public class Brush : MonoBehaviour {

	private Vector2 offset, pos;
	public Canvas myCanvas;
	public GameObject sujeira, fade;

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
			StartCoroutine (limparSujeira (5f));
		}
	}

	private IEnumerator limparSujeira(float determinadoTempo){

		if (sujeira.GetComponent<CanvasGroup> ().alpha > 0f) {
			sujeira.GetComponent<CanvasGroup> ().alpha -= 0.005f;
			yield return new WaitForSecondsRealtime (determinadoTempo);
		} 
		else if (sujeira.GetComponent<CanvasGroup> ().alpha == 0) {
			yield return new WaitForSecondsRealtime (2f);
			fade.GetComponent<CanvasGroup> ().alpha += 0.05f;
			if (fade.GetComponent<CanvasGroup> ().alpha == 1) {
				yield return new WaitForSecondsRealtime (1f);
				UnityEngine.SceneManagement.SceneManager.LoadScene (3);
			}
		}
	}
}