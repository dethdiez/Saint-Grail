using UnityEngine;
using System.Collections;

public enum effect {vampirism, dazzle, poison, concentrating, breakout, divineTear};
public enum affect {missing, poison, regeneration};

public class Effects : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public static float vampirism (float damage) {
		return damage * 0.1f;
	}

	public static void dazzle (Unit onDef) {
		if (Random.Range (0.0f, 100.0f) <= 10.0f) {
			BattleEventController.setAffect (onDef, (int)affect.missing, 2, 65.0f);
		}
	}

	public static void poison (Unit onDef, float damage) {
		if (Random.Range (0.0f, 100.0f) <= 40.0f) {
			BattleEventController.setAffect (onDef, (int)affect.poison, 2, 0.2f * damage);
		}
	}

	public static bool concentrating () {
		if (Random.Range (0.0f, 100.0f) <= 10.0f) {
			return true;
		} else
			return false;
	}

	public static bool breakout () {
		if (Random.Range (0.0f, 100.0f) <= 20.0f) {
			return true;
		} else
			return false;
	}

	public static bool divineTear () {
		if (Random.Range (0.0f, 100.0f) <= 10.0f) {
			return true;
		} else
			return false;
	}

	public static bool miss() {
		return Random.Range (0.0f, 100.0f) <= 10.0f;
	}
}
