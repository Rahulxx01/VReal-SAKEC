using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class NoToggle : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine (DeactivatorVR("none"));
	}
	public IEnumerator DeactivatorVR(string yesVR){
		XRSettings.LoadDeviceByName (yesVR);
		yield return null;
		XRSettings.enabled = false;
	}

}
