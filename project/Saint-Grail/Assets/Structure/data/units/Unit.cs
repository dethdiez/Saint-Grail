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
//		stats = new Stats ();
		Debug.Log ("Unit Created");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public Stats getStats() {
		return stats;
	}

	public bool getEffect (int name) {
		return effects [name];
	}

	public affects getAffect (int name) {
		return aff [name];
	}

	public void setEffect(int name, bool isExist) {
		effects [name] = isExist;
	}

	public void setAffect(int name, int time, float value) {
		aff [name].time  = time;
		aff [name].value = value;
	}

	public void decAffectTime (int name) {
		aff [name].time -= 1;
	}

	protected Stats stats = new Stats ();
	protected bool[] effects = new bool[7];
	protected affects[] aff = new affects[7];
}
