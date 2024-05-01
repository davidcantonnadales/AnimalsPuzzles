using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelSystem : MonoBehaviour {
	public GameObject[] LevelBtn;
	public Sprite[] Imagez;

	public GameObject WarningUI;
	[SerializeField] private bool OpenAll = false;

	void Start(){
		//PlayerPrefs.DeleteAll();
		PlayerPrefs.SetInt("game00",1);
		for (int i = 0; i < LevelBtn.Length; i++)
		{	
			int nomer = int.Parse(LevelBtn[i].name) - 1 ;
			if(!OpenAll){
				if(PlayerPrefs.GetInt("game0"+nomer) <= 0){
					LevelBtn[i].GetComponent<Button>().interactable = false;
					Debug.Log("buttonya mati"+i +" = null");
				}
				else{
					LevelBtn[i].GetComponent<Button>().interactable = true;
				}
			}
			else{
				LevelBtn[i].GetComponent<Button>().interactable = true;
			}
		}
	}

	public void menu(){
		Music_Singleton.Instance.s_play(1);
		UIz.kk = "MainMenu";
		GameObject.Find("Canvas").GetComponent<Animator>().Play("end");
	}

	public void WUI_Open(){
		Music_Singleton.Instance.s_play(1);
		WarningUI.active = true;
	}

	public void btn_No(){
		Music_Singleton.Instance.s_play(1);
		WarningUI.GetComponent<Animator>().Play("end");
	}

	public void btn_yes(){
		Music_Singleton.Instance.s_play(1);
		PlayerPrefs.DeleteAll();
		PlayerPrefs.SetInt("game00",1);
		Start();
		WarningUI.GetComponent<Animator>().Play("end");
	}
}
