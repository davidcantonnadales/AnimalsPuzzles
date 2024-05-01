using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuSystem : MonoBehaviour {

	public void btn_moregames(string kemana){
		Music_Singleton.Instance.s_play(1);
		Application.OpenURL ("market://search?q="+kemana);
	}
	public void btn_rateus(string kemana){
		Music_Singleton.Instance.s_play(1);
		Application.OpenURL ("market://details?id="+kemana);
	}
	public void btn_play(){
		UIz.kk = "SelectMenu";
		GameObject.Find("Canvas").GetComponent<Animator>().Play("end");
		Music_Singleton.Instance.s_play(1);
	}

	void Update () {

		if(Input.GetKeyDown(KeyCode.Escape)){
			        {
             if (Application.platform == RuntimePlatform.Android)
             {
                 Application.Quit();
             }
             else
             {
                 Application.Quit();
             }
         }
		}
		
	}
}
