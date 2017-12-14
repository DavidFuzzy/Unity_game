using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManagerWin : MonoBehaviour {

	public void NextScene(string sceneSwitch)
	{
		SceneManager.LoadScene("Start");
	}

	public void exit()
	{
		UnityEditor.EditorApplication.isPlaying = false;
	}
}
