﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//isBoth ();
	}

	public void attackClick() {
		Debug.Log ("attack toggle selected with " + gameObject.GetComponent<Toggle>().isOn);
		BattleEventController.attackClick (gameObject.GetComponent<Toggle>().isOn);
	}

	public void defClick() {
		Debug.Log ("defence toggle selected");
		BattleEventController.defenceClick (true);
	}


}
