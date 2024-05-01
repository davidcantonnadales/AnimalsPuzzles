using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class GameSystem : MonoBehaviour {
	[SerializeField] private int id;
	[SerializeField] private TextMeshProUGUI tm ;
	public GameObject[] BG;
	public GameObject[] UI;
	public GameObject[] GamePuzzle;
	private ImagesAssets seted;
	public ImagesAssets[] Assets;

	[SerializeField] private bool GameStart ; 

	[SerializeField]private int id_Game;

	

	// Use this for initialization
	void Awake () {	
		id = Data.LevelNow;
		scramble();		
	}

	void Start()
	{	
		PlayerPrefs.SetInt("game0"+Data.LevelNow,1);
		GameStart = false;
		win = false;
		Invoke("active",1f);	
	}

	public void scramble(){
		//Music_Singleton.Instance.s_play(1);
		int lepel = Data.LevelNow + 1 ;
		if(Data.LevelNow < 9){
			tm.text = "PUZZLE - 00"+lepel;
		}
		else if(Data.LevelNow < 99){
			tm.text = "PUZZLE - 0"+lepel;
		}
		else if(Data.LevelNow >= 99){
			tm.text = "PUZZLE - "+lepel;
		}
		int[] rotation = {0,1,2,3};
		seted = Assets[id];
		BG[0].GetComponent<RawImage>().texture = seted.FullImage;
		BG[1].GetComponent<RawImage>().texture = seted.FullImage;
		for (int i = 0; i < GamePuzzle.Length; i++)
		{	
			GamePuzzle[i].GetComponent<button_Script>().idku = 	Random.Range(0,rotation.Length);
			//GamePuzzle[i].transform.Rotate(0,0,rotation[Random.Range(0,rotation.Length)]);
			GamePuzzle[i].GetComponent<Image>().sprite = seted.img[i];
		}

		
	}
	public void scramblez(){
		Music_Singleton.Instance.s_play(1);
		int lepel = Data.LevelNow + 1 ;
		int[] rotation = {0,1,2,3};
		seted = Assets[id];
		BG[0].GetComponent<RawImage>().texture = seted.FullImage;
		BG[1].GetComponent<RawImage>().texture = seted.FullImage;
		for (int i = 0; i < GamePuzzle.Length; i++)
		{	
			GamePuzzle[i].GetComponent<button_Script>().idku = 	Random.Range(0,rotation.Length);
			//GamePuzzle[i].transform.Rotate(0,0,rotation[Random.Range(0,rotation.Length)]);
			GamePuzzle[i].GetComponent<Image>().sprite = seted.img[i];
		}

		
	}

	void active(){
		GameStart = true;
	}

	public static bool win = false;
	void Update(){
		if(GameStart){
			if(!win){
				if(	GamePuzzle[0].transform.rotation.z == 0 &&
					GamePuzzle[1].transform.rotation.z == 0 &&
					GamePuzzle[2].transform.rotation.z == 0 &&
					GamePuzzle[3].transform.rotation.z == 0 &&
					GamePuzzle[4].transform.rotation.z == 0 &&
					GamePuzzle[5].transform.rotation.z == 0 &&
					GamePuzzle[6].transform.rotation.z == 0 &&
					GamePuzzle[7].transform.rotation.z == 0 &&
					GamePuzzle[8].transform.rotation.z == 0 &&
					GamePuzzle[9].transform.rotation.z == 0 &&
					GamePuzzle[10].transform.rotation.z == 0 &&
					GamePuzzle[11].transform.rotation.z == 0 &&
					GamePuzzle[12].transform.rotation.z == 0 &&
					GamePuzzle[13].transform.rotation.z == 0 &&
					GamePuzzle[14].transform.rotation.z == 0 &&
					GamePuzzle[15].transform.rotation.z == 0 
				){
					Debug.Log("benar");
					Music_Singleton.Instance.s_play(2);
					Music_Singleton.Instance.s_play(3);
					PlayerPrefs.SetInt("game0"+Data.LevelNow,1);
					Invoke("winner",0.5f);
					win = true;
				}
			}
		}		
	}

	public void winner(){
		UI[1].active = true;
	}

	public void next(){
		Invoke("changed",0.55f);		
		Music_Singleton.Instance.s_play(1);
		UI[1].GetComponent<Animator>().Play("end");

	}

	void changed(){
		int news = Assets.Length - 1;
		if(Data.LevelNow >= news){
			Data.LevelNow = 0 ;
		}
		else{
			Data.LevelNow++;
		}
	}
	public void restart(){
		//Data.LevelNow++;
		Music_Singleton.Instance.s_play(1);
		UI[1].GetComponent<Animator>().Play("end");

	}

	public void kemana(string oh){
		UIz.kk = oh;
		Music_Singleton.Instance.s_play(1);
		UI[0].GetComponent<Animator>().Play("end");

	}



	
	
	
}
