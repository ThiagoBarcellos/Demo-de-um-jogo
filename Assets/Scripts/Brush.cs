using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(CircleCollider2D))]

public class Brush : MonoBehaviour {

	private Vector2 offset, pos;
	public Canvas myCanvas;
	Texture2D texture = new Texture2D(128, 128);

	void Start(){
		GetComponent<Renderer>().material.mainTexture = texture;
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

	void OnTriggerEnter2D(Collider coll){

		if (coll.gameObject.CompareTag ("dirt")) {
			for (int y = 0; y < texture.height; y++) {
				for (int x = 0; x < texture.width; x++) {
					Color color = ((x & y) != 0 ? Color.white : Color.gray);
					texture.SetPixel (x, y, color);
				}
			}
			texture.Apply ();
		}
	}
}