using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager2 : MonoBehaviour {
	public static int PlayerScore1; // = 0;
	public static int PlayerScore2; // = 0;

	public GUISkin layout;

	GameObject theBall;

	void Start () {
		theBall = GameObject.FindGameObjectWithTag("Ball");
	}

	public static void Score (string wallID) {
		if (wallID == "right_score")
		{
			PlayerScore1++;
		} else
		{
			PlayerScore2++;
		}
	}

	void OnGUI () {
		GUI.skin = layout;
		GUI.Label(new Rect(Screen.width / 2 - 150 - 12, 20, 100, 100), "" + PlayerScore1);
		GUI.Label(new Rect(Screen.width / 2 + 150 + 12, 20, 100, 100), "" + PlayerScore2);



		if (PlayerScore1 == 7)
		{			
			NextLevel();
		} 

		else if (PlayerScore2 == 7)
		{			
			NextLevel();
		}

	}

	void NextLevel() {
		SceneManager.LoadScene("Winner");
	}
}