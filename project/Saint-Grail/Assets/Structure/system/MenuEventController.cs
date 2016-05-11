using UnityEngine;
using System.Collections;

public class MenuEventController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public static void newGame(){
		EventController.loadNew ();
	}
}
