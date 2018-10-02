using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class MainSceneRouter : MonoBehaviour {

	// Use this for initialization
	void Start () {
		SceneManager.LoadScene ("SampleScene", LoadSceneMode.Single);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void playButtonOnClick(){
		
		//SceneManager.LoadScene ("SampleScene", LoadSceneMode.Additive);
		Debug.Log ("inside the method");
	}

	
}
