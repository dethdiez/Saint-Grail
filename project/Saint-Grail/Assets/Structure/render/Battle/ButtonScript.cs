using UnityEngine;
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

	public void attackClick(int region) {
		Debug.Log ("attack toggle selected with " + gameObject.GetComponent<Toggle>().isOn);
		BattleEventController.attackClick (gameObject.GetComponent<Toggle>().isOn, region);
	}

	public void defClick(int region) {
		Debug.Log ("defence toggle selected with " + gameObject.GetComponent<Toggle>().isOn);
		BattleEventController.defenceClick (gameObject.GetComponent<Toggle>().isOn, region);
	}

	public void toDefault () {
		if (gameObject.GetComponent<Toggle> ().isOn) {
			gameObject.GetComponent<Toggle> ().isOn = false;
			Debug.Log ("ButtonScript. Try to default. Toggle isOn of object named " + gameObject.name + " = " + gameObject.GetComponent<Toggle> ().isOn);
		}
	}

}
