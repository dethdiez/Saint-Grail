using UnityEngine;
using System.Collections;

public class ToFree : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void loadFree(bool isNew) {
		if (isNew) {
			MenuEventController.newGame ();
		}
	}
}
