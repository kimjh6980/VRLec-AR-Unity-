using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TouchObject : MonoBehaviour {

	private GameObject alchemistI;
	private bool act = true;
	private Text alchemistT;
	private int alchemistcount;

	// Use this for initialization
	void Start () {
		alchemistI = GameObject.FindGameObjectWithTag ("tag1");
		alchemistT = GameObject.GetComponent<Text>;
		alchemistcount = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.touchCount > 0) {
			Vector2 pos = Input.GetTouch (0).position;
			Vector3 theTouch = new Vector3 (pos.x, pos.y, 0.0f);

			Ray ray = Camera.main.ScreenPointToRay (theTouch);

			RaycastHit hit = new RaycastHit ();
			if (Physics.Raycast (ray, out hit, Mathf.Infinity)) {
				if (hit.collider.CompareTag ("tag1")) {
					if (Input.GetTouch (0).phase == TouchPhase.Began) 
					{
					} else if (Input.GetTouch (0).phase == TouchPhase.Ended) {
						Destroy (hit.collider.gameObject);
						alchemistcount++;
						alchemistT.text = alchemistcount.ToString();
					}
				}
			}
		}
	}
}

