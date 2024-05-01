using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dondestroy : MonoBehaviour {

	

 private void Awake()
 {
	 


	 DontDestroyOnLoad(this.gameObject);
 }
}
