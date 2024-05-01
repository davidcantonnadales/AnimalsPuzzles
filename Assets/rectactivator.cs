using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rectactivator : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GetComponent<RectMask2D>().enabled = true;
	}
}