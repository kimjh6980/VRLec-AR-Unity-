using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchObject3 : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (Input.touchCount > 0) {
			Vector2 pos = Input.GetTouch (0).position;
			Vector3 theTouch = new Vector3 (pos.x, pos.y, 0.0f);

			Ray ray = Camera.main.ScreenPointToRay (theTouch);

			RaycastHit hit = new RaycastHit ();
			if (Physics.Raycast (ray, out hit, Mathf.Infinity)) {
				if (hit.collider.CompareTag ("tag3")) {
					if (Input.GetTouch (0).phase == TouchPhase.Began) {

					} else if (Input.GetTouch (0).phase == TouchPhase.Ended) {
						Destroy (hit.collider.gameObject);
					}
				}
			}
		}
	}
}
