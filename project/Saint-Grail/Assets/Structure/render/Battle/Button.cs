using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void attackClick() {
		BattleEventController.attackClick (true);
	}

	public void defClick() {
		BattleEventController.defenceClick (true);
	}

//	public void defaultScale() {
//		gameObject.GetComponent<RectTransform>().
//	}
}
