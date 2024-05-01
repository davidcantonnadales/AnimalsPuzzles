using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PemanggilBanner : MonoBehaviour {

	// Use this for initialization
	void Start () {
		InitializeAdmob.instance.showbanner();
	}
	
}
