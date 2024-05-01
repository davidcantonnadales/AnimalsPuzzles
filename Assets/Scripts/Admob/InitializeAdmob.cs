using System.Collections;
using System.Collections.Generic;
using GoogleMobileAds.Api;
using UnityEngine;
//using UnityEngine.Advertisements;

public class InitializeAdmob : MonoBehaviour {

	private static BannerView admob_Banner;
	private static InterstitialAd admob_Inter;
	private string Admob_Banner_ID = "ca-app-pub-8989292844401169/5054202432";
	private string Admob_Interstitial_ID = "ca-app-pub-8989292844401169/8037133582";

	public static InitializeAdmob _instance;
	public static InitializeAdmob instance{
		get{return _instance;}
	}


	private int tipe;
	public static bool iklan = false;
	private int Iklan_Frequency = 1 ; // change ads freq ex 1:2:3:4:5
	// Use this for initialization
	


	void Awake () {

		if(_instance == null){
			_instance = this;
			DontDestroyOnLoad(this);
		}
		else{
			Destroy(this.gameObject);
		}

		iklan = false;
		tipe = Random.Range(0,6);
		//tipe = 2;
	//	Debug.Log("Ini Nilai Untuk Iklan "+tipe);

		showbanner();
		requestInter();
		
	}

	void Start(){
		cekiklan();
	}

	void cekiklan(){
		if(PlayerPrefs.GetFloat("idx") == null){
			PlayerPrefs.SetFloat("idx",2);
		}
		else{
			Data.iklan_index = PlayerPrefs.GetFloat("idx") ;
		}
	}
	
	// Update is called once per frame
	public void reqbanner(){
		
        string adUnitIdbanner = Admob_Banner_ID;
		AdRequest request = new AdRequest.Builder()
		.Build();
		admob_Banner = new BannerView(adUnitIdbanner,AdSize.SmartBanner,AdPosition.Bottom);	
		admob_Banner.LoadAd(request);


	}

	public void requestInter(){
		string adunitinterstitial = Admob_Interstitial_ID;
		admob_Inter = new InterstitialAd(adunitinterstitial);
 
		AdRequest request_inter = new AdRequest.Builder()
		.Build();
		admob_Inter.OnAdClosed += Interstitial_OnAdClosed;
		admob_Inter.LoadAd(request_inter);


		
	}

	private void Interstitial_OnAdClosed(object sender, System.EventArgs e)
    {
		iklan = false;	
        requestInter();
		

    }
	public void showfullads(){
		if (admob_Inter != null && admob_Inter.IsLoaded()){
			admob_Inter.Show();
		}
		else{
			requestInter();
			
		}
	}

	public void showbanner(){
		if(admob_Banner != null){
			//admob_Banner.Show();
		}
		else{
			reqbanner();
			
		}
	}
	/*
	public void Show_RewardedAd()
              {
                if (Advertisement.IsReady("rewardedVideo"))
                {
                  var options = new ShowOptions { resultCallback = HandleShowResult };
                  Advertisement.Show("rewardedVideo", options);
                }
    }

	private void HandleShowResult (ShowResult result){
            if (result == ShowResult.Finished)
            {	
				iklan = false;
				
            }
 	}

	public void Show_Videoads()              {
                if (Advertisement.IsReady("video"))
                {
                  var options = new ShowOptions { resultCallback = HandleShowResultz };
                  Advertisement.Show("video", options);
                }
    }

	private void HandleShowResultz (ShowResult result){
            if (result == ShowResult.Finished)
            {	
				iklan = false;
				
            }
 	}

	 */

	
	public void Show_Ads_Full(){

		if(Data.iklan_index >= Iklan_Frequency){
				if(tipe >= 0){
					showfullads();
					tipe = Random.Range(0,6);
					Debug.Log("admob muncul");
				
				}
			/*	else if(tipe == 1){
					Show_RewardedAd();
					tipe = Random.Range(0,6);
				}
			*/	
			/*	else if(tipe < 2 ){
					Show_Videoads();
					tipe = Random.Range(0,6);
				}
			*/	
				
				PlayerPrefs.SetFloat("idx",1);
				Data.iklan_index = PlayerPrefs.GetFloat("idx");
			
		}
		else{
			Data.iklan_index++;
			PlayerPrefs.SetFloat("idx",Data.iklan_index);

		}
		
	}


	


	




}
