using UnityEngine;
using System.Collections;

public class EventController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public static void goBattle(Enemy enemy) {
		ToBattleGui.showWindow ();
	}
}
