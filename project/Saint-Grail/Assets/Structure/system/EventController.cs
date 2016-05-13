﻿using UnityEngine;
using System.Collections;
using Statistics;

public class EventController : MonoBehaviour {

	public static Hero hero;
	public static Enemy enemy;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public static void goBattle(Enemy monster) {
		Debug.Log ("Event goBattle created");
		isBattle = true;
		enemy = monster;
		ToBattle.showWindow ();
	}

	public static bool checkBattle() {
		return isBattle;
	}

	public static void setToBattle (Unit unit, bool isHero) {
		BattleEventController.setToBattle (unit, isHero);
	}

	public static void attributesHasChanged (Unit unit, int name, float upd) {
		switch (name) {
		case (int)attrName.ability:
			unit.getStats ().UpdStat ((int)statName.damage, 1 * upd);
			unit.getStats ().UpdStat ((int)statName.resist, 1 * upd);
			unit.getStats ().UpdStat ((int)statName.energy, -6 * upd);
			unit.getStats ().UpdStat ((int)statName.health, -6 * upd);
			updSpell ();
			break;

		case (int)attrName.faith:
			unit.getStats ().UpdStat ((int)statName.energy, 12 * upd);
			unit.getStats ().UpdStat ((int)statName.resist, 1 * upd);
			break;

		case (int)attrName.protection:
			unit.getStats ().UpdStat ((int)statName.resist, 1 * upd);
			unit.getStats ().UpdStat ((int)statName.damage, -1 * upd);
			unit.getStats ().UpdStat ((int)statName.energy, -6 * upd);
			break;

		case (int)attrName.violence:
			unit.getStats ().UpdStat ((int)statName.damage, 3 * upd);
			unit.getStats ().UpdStat ((int)statName.resist, -1 * upd);
			unit.getStats ().UpdStat ((int)statName.health, -6 * upd);
			break;

		case (int)attrName.vitality:
			unit.getStats ().UpdStat ((int)statName.health, 15 * upd);
			unit.getStats ().UpdStat ((int)statName.resist, -1 * upd);
			unit.getStats ().UpdStat ((int)statName.energy, -3 * upd);
			break;

		default:
			Debug.Log ("Error: incorrect attribute name for update stat");
			break;
		}
	}

	public static void updSpell() {

	}

	public static void loadNew() {
		FieldCreator.setNumber (0);
		Application.LoadLevel ("free");
	}

	private static bool isBattle = false;
}
