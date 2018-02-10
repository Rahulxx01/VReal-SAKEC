using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class VrToggle : MonoBehaviour {

	// Use this for initialization
	public void Start () {
		StartCoroutine (ActivatorVR("cardboard"));
	}
	public IEnumerator ActivatorVR(string yesVR){
		XRSettings.LoadDeviceByName (yesVR);
		yield return null;
		XRSettings.enabled = true;
	}
	

}
