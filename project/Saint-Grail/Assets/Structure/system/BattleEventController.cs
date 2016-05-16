using UnityEngine;
using System.Collections;
using Statistics;

public class BattleEventController : MonoBehaviour {

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

	public static void attackClick(bool value) {
		isAttackClicked = value;
		BattleEventController.isBoth ();
		Debug.Log ("Event attackClick created, isAttackCliked = " + isAttackClicked);
	}

	public static void defenceClick(bool value) {
		isDefenceClicked = value;
		BattleEventController.isBoth ();
		Debug.Log ("Event defenceClick created, isDefenceCliked = " + isDefenceClicked);
	}

	public static bool isBoth() {
		return isAttackClicked && isDefenceClicked;
	}

	public static void toAttack(bool isHero) {
		string tag;
		if (isHero)
			tag = "Hero";
		else
			tag = "Enemy";
		GameObject.FindGameObjectWithTag(tag).GetComponent<ToStay> ().toAttack ();
	}

	public static void toMagic(bool isHero) {
		string tag;
		if (isHero)
			tag = "Hero";
		else
			tag = "Enemy";
		GameObject.FindGameObjectWithTag(tag).GetComponent<ToStay> ().toMagic ();
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

	private static bool isAttackClicked;
	private static bool isDefenceClicked;
}
