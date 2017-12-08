using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelManager : MonoBehaviour {

	public void NextScene(string sceneSwitch)
    {
        SceneManager.LoadScene(sceneSwitch);
    }

    public void exit()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
