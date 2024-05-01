using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button_Script : MonoBehaviour {
	public int idku ;

	private void Start(){
	}
	public void tersentuh(){
		if(!GameSystem.win){
			if(idku <= 2){
				idku++;
			}
			else{
				idku = 0;
			}
		}
		Music_Singleton.Instance.s_play(0);

		
	}

	public void Update(){
		if(idku == 0 ){
			transform.rotation = Quaternion.Euler(0,0,0);
		}
		else if(idku == 1){
			transform.rotation = Quaternion.Euler(0,0,270);
		}
		else if(idku == 2){
			transform.rotation = Quaternion.Euler(0,0,180);
		}
		else if(idku == 3){
			transform.rotation = Quaternion.Euler(0,0,90);
		}
	}


}
