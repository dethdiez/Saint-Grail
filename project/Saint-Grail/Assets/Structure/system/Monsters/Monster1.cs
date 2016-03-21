using UnityEngine;
using System.Collections;

public class Monster1 : Enemy {

	public bool col = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D collision) {
//		EventController.goBattle (this);
		col = true;
		ToBattleGui.showWindow();
	}

}
