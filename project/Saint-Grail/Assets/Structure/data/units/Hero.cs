using UnityEngine;
using System.Collections;
using Statistics;

public class Hero : Unit {

	// Use this for initialization
	void Start () {
		Debug.Log ("Hero created");
		attributes = new Attributes();
//		stats = new Stats ();
		stats.setDefaultStats (0);
		Debug.Log (stats.GetStat (0));
	}
	
	// Update is called once per frame
	void Update () {
//		if (EventController.checkBattle ()) {
//			EventController.setToBattle (this, true);
//		}

//		EventController.hero = this;
	}

	public void setType (int t) {
		type = t;
	}

	public int getType() {
		return type;
	}

	public Attributes getAttributes() {
		return attributes;
	}


	private int type;
	private Attributes attributes;
}
