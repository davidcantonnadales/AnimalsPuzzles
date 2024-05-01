using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class SelectBtn : MonoBehaviour {
	[SerializeField] private TextMeshProUGUI teks;

	// Use this for initialization
	void Start () {
		teks.text = this.name.ToString();
	//	Debug.Log(this.name);


		
	}
	
	public void button_start(){
		Data.LevelNow = int.Parse(this.name) - 1;
		Music_Singleton.Instance.s_play(1);
		//SceneManager.LoadScene("Game");
	//	Debug.Log(this.name);
		UIz.kk = "Game";
		GameObject.Find("Canvas").GetComponent<Animator>().Play("end");
	}


	
}
