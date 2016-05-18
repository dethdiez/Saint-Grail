using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ButtonScript2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		isBoth ();
	}

	public void isBoth() {
		if (BattleEventController.isBoth ())
			gameObject.GetComponent<Button> ().interactable = true;
		else
			gameObject.GetComponent<Button> ().interactable = false;
	}

	public void step(int type) {
		Debug.Log ("Action button clicked, method step. Type = " + type);
		Fight.step (type);
	}
}
