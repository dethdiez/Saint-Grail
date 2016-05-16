using UnityEngine;
using System.Collections;

public class Enemy : Unit {

	// Use this for initialization
	void Start () {
		Debug.Log ("Enemy created");
		stats.NewStats (4, 2, 10, 10, 1);
//		stats.setDefaultStats (0);
		Debug.Log (stats.GetStat (0));

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D collision) {
		EventController.goBattle (this);
	}
}
