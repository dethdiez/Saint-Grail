using UnityEngine;
using System.Collections;

public class FreeButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void toMainMenu(){
		EventController.loadMainMenu ();
	}
}
