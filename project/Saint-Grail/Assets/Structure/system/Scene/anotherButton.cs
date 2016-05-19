using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class anotherButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

//	public void enablePanel() {
//		panel.SetActive (true);
//	}



	public void toFree() {
		Application.LoadLevel ("Free");
	}
}
