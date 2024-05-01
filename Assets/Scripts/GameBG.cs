using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameBG : MonoBehaviour {
	private string now ;
	public Texture[] BGImage;
	public GameObject BGnya;

	private static GameBG _instance = null;
	public static GameBG Instance
	{
		get {return _instance ; }
	}

	void Awake(){
		if(_instance == null){
			
			_instance = this;
			DontDestroyOnLoad(this);
		}
		else{
			Destroy(this.gameObject);
		}
	}
	void Update(){
		now = SceneManager.GetActiveScene().name;
		if(now == "Game"){
			BGnya.GetComponent<RawImage>().texture = BGImage[Data.LevelNow];
		}
	}
}
