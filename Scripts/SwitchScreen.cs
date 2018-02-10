using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScreen : MonoBehaviour {

/*	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		
	}*/

	public void changeScreen(int changeTheScene){
		SceneManager.LoadScene (changeTheScene);
	}


}
