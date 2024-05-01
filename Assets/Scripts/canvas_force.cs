using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class canvas_force : MonoBehaviour {

	[SerializeField]
	private GameObject cam;
	// Use this for initialization
	void Update () {
		cam = GameObject.Find("Main Camera");
		GetComponent<Canvas>().worldCamera = cam.GetComponent<Camera>();
		
	}
	
}
