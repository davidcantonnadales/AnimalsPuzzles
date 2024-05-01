using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music_Singleton : MonoBehaviour {
	private static Music_Singleton _instance = null;
	public static Music_Singleton Instance
	{
		get {return _instance ; }
	}

	public AudioClip[] suara ;
	public AudioSource[] source;

	void Awake(){
		if(_instance == null){
			_instance = this;
			DontDestroyOnLoad(this);
		}
		else{
			Destroy(this.gameObject);
		}
	}

	void Start(){
		for (int i = 0; i < source.Length; i++)
		{
			source[i] = gameObject.AddComponent<AudioSource>();
			source[i].clip = suara[i];
		}
	}

	public void s_play(int i){
		source[i].Play();
	}


}
