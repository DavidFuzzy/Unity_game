using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Winner : MonoBehaviour {

	int  PlayerOne_Total = GameManager.PlayerScore1 + GameManager1.PlayerScore1 + GameManager2.PlayerScore1;
	int PlayerTwo_Total = GameManager.PlayerScore2 + GameManager1.PlayerScore2 + GameManager2.PlayerScore2;

	void Start(){
	}	

	void OnGUI () {
		if (PlayerOne_Total > PlayerOne_Total){
			GUI.Label(new Rect(Screen.width / 2 - 0 - 12, 20, 100, 100), "" + "PLAYER ONE IS THE WINNER");
		}
		else{
			GUI.Label(new Rect(Screen.width / 2 - 0 - 12, 20, 100, 100), "" + "PLAYER TWO IS THE WINNER");
		}
	
	}

}