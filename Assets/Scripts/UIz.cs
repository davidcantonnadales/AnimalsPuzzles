using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIz : MonoBehaviour {

	public static string kk;
	public void restart(){
		string now = SceneManager.GetActiveScene().name;
		SceneManager.LoadScene(now);
	}


	public void iklan(){
		InitializeAdmob._instance.Show_Ads_Full();
	}
	public void kemana(){
		
		SceneManager.LoadScene(kk);
	}

	public void gakaktif(){
		this.gameObject.active = false;
	}


}
