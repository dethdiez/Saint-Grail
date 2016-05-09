using UnityEngine;
using System.Collections;
using Statistics;

public class Hero : Unit {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void setType (int t) {
		type = t;
	}

	public static int getType() {
		return type;
	}

	private static int type;
	private static Attributes attributes;
}
