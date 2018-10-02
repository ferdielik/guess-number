using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class MainSceneRouter : MonoBehaviour {

	public void OpenScene(string sceneName){
        SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
	}

}
