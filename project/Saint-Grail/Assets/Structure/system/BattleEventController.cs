using UnityEngine;
using System.Collections;
using Statistics;
using UnityEngine.UI;

public class BattleEventController : MonoBehaviour {

	public static int heroAttackRegion;
	public static int heroDefRegion;

	public Points[] points;

	// Use this for initialization
	void Start () {
		points [0].stats = EventController.hero.getStats ();
		points [1].stats = EventController.enemy.getStats ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public static void setAffect(Unit unit, int name, int time, float value) {
		unit.setAffect (name, time, value);
	}

	public static void setToBattle (Unit unit, bool isHero) {

	}

	public static void updHealth (float value, Unit unit) {
		unit.getStats ().UpdCurPoints ((int)statName.health, value);
	}

	public static void attackClick(bool value, int region) {
		isAttackClicked = value;
		heroAttackRegion = region;
		BattleEventController.isBoth ();
		Debug.Log ("Event attackClick created, isAttackCliked = " + isAttackClicked);
		Debug.Log ("BattleEventController. attackClick. region = " + heroAttackRegion);
	}

	public static void defenceClick(bool value, int region) {
		isDefenceClicked = value;
		heroDefRegion = region;
		BattleEventController.isBoth ();
		Debug.Log ("Event defenceClick created, isDefenceCliked = " + isDefenceClicked);
		Debug.Log ("BattleEventController. defenceClick. region = " + heroDefRegion);
	}

	public static bool isBoth() {
		return isAttackClicked && isDefenceClicked;
	}

	public static void toAttack(bool isHero) {
		Debug.Log ("Event toAttack created with " + isHero);
		string tag;
		if (isHero)
			tag = "Hero";
		else
			tag = "Enemy";
		Debug.Log ("BEC. tag " + tag);
		GameObject obj;
		obj = GameObject.FindGameObjectWithTag (tag);
		obj.GetComponent<ToStay> ().toAttack ();
	}

	public static void toMagic(bool isHero) {
		Debug.Log ("Magic?");
		string tag;
		tag = "Hero";
		GameObject.FindGameObjectWithTag (tag).GetComponent<ToStay> ().toMagic ();
	}

	public static void toDeath(bool isHero) {
		string tag;
		if (isHero)
			tag = "Hero";
		else
			tag = "Enemy";
		GameObject.FindGameObjectWithTag(tag).GetComponent<ToStay> ().toDeath ();
	}

	public static void setReady (bool value) {
		GameObject.FindGameObjectWithTag ("Hero").GetComponent<Animator> ().SetBool ("isReady", value);
		GameObject.FindGameObjectWithTag ("Enemy").GetComponent<Animator> ().SetBool ("isReady", value);
	}

	public static void toDefault () {
		Debug.Log ("Try to set toggles to default");
		GameObject[] AttObj = GameObject.FindGameObjectsWithTag ("Attack");
		GameObject[] DefObj = GameObject.FindGameObjectsWithTag ("Defence");
		for (int i = 0; i < 6; i++) {
			AttObj [i].GetComponent<ButtonScript> ().toDefault ();
			DefObj [i].GetComponent<ButtonScript> ().toDefault ();
		}
	}

	private static bool isAttackClicked;
	private static bool isDefenceClicked;
}
