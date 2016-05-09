using UnityEngine;
using System.Collections;
using Statistics;

public class Unit : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public Stats getStats() {
		return stats;
	}

	public void setEffect(int name, int time) {
	}

	protected Stats stats;
	protected bool[] effects;
	protected bool[] affects;
}
