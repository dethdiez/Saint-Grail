using UnityEngine;
using System.Collections;
using Statistics;

public class Fight : MonoBehaviour {


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public static void step() {
		Stats heroStats = EventController.hero.getStats();
		Stats enemyStats = EventController.enemy.getStats();
		Debug.Log ("New fight step");
		BattleEventController.toAttack (true);
		hit (EventController.hero, EventController.enemy);
		BattleEventController.setReady (false);
		while (GameObject.FindGameObjectWithTag ("Hero").GetComponent<ToStay> ().isReady () || GameObject.FindGameObjectWithTag ("Enemy").GetComponent<ToStay> ().isReady ()) {
			
		}
		BattleEventController.toAttack (false);
		hit (EventController.enemy, EventController.hero);
		if (EventController.hero.getAffect ((int)affect.poison).time > 0) {
			BattleEventController.updHealth (EventController.hero.getAffect ((int)affect.poison).value, EventController.hero);
			EventController.hero.decAffectTime ((int)affect.poison);
		}
		if (EventController.enemy.getAffect ((int)affect.poison).time > 0) {
			BattleEventController.updHealth (EventController.enemy.getAffect ((int)affect.poison).value, EventController.enemy);
			EventController.enemy.decAffectTime ((int)affect.poison);
		}
	}

	public static void hit (Unit onAt, Unit onDef) {
		Debug.Log ("Hit!");
		float damage = onAt.getStats ().GetStat ((int)statName.damage);
		Debug.Log ("Default damage" + damage);
		bool isMiss = false;
		bool isGodsHelp = false;

		if (onAt.getAffect ((int)affect.missing).time > 0) {
			isMiss = Effects.miss ();
			onAt.decAffectTime ((int)affect.missing);
		} else if (onDef.getEffect ((int)effect.divineTear)) {
			isGodsHelp = Effects.divineTear ();
		}

		if (isMiss || isGodsHelp) {
			damage = 0;
		} else {
			float resist = onDef.getStats ().GetStat ((int)statName.resist);

			if (onAt.getEffect ((int)effect.breakout)) {
				if (Effects.breakout ()) {
					resist = resist / 2;
				}
			}

			if (onAt.getEffect ((int)effect.concentrating)) {
				if (Effects.concentrating ()) {
					damage = damage * 2;
				}
			}

			if (onAt.getEffect ((int)effect.dazzle)) {
				Effects.dazzle (onDef);
			}
		
			if (onAt.getEffect ((int)effect.poison)) {
				Effects.poison (onDef, damage);
			}

			if (onAt.getEffect ((int)effect.vampirism)) {
				BattleEventController.updHealth (Effects.vampirism (damage), onAt);
			}
			damage -= resist;
		}
		Debug.Log ("final damage" + damage);
		BattleEventController.updHealth (-damage, onDef);
	}
}

//unit.getStats ().UpdCurPoints ((int)statName.health, damage);