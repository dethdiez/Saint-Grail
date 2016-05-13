using UnityEngine;
using System.Collections;
using Statistics;

public class BattleEventController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
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

	public static void attackClick() {
//		if (isAttackClicked)
//			lastAttack.defaultScale ();
		isAttackClicked = true;
//		lastAttack = button;
	}

	public static void attackClick(bool value) {
		//		if (isAttackClicked)
		//			lastAttack.defaultScale ();
		isAttackClicked = value;
		BattleEventController.isBoth ();
		//		lastAttack = button;
	}

	public static void defenceClick(bool value) {
		isDefenceClicked = value;
		BattleEventController.isBoth ();
	}

	public static void isBoth() {
		if (isAttackClicked && isDefenceClicked) {

		}
	}

//	private static Button lastAttack;
//	private static Button lastDefence;
	private static bool isAttackClicked;
	private static bool isDefenceClicked;
}
