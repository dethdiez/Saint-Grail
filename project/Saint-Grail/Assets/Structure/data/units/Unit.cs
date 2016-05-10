using UnityEngine;
using System.Collections;
using Statistics;

public struct affects {
	public int time;
	public float value;
}

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

	public void setEffect(int name, bool isExist) {
		effects [name] = isExist;
	}

	public void setAffect(int name, int time, float value) {
		aff [name].time  = time;
		aff [name].value = value;
	}

	protected Stats stats;
	protected bool[] effects;
	protected affects[] aff;
}
