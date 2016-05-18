using UnityEngine;
using System.Collections;
using Statistics;

public enum attackType {meele, magic};
public enum region {chest, head, left_hand, left_leg, right_hand, right_leg};

public class Fight : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public static void step(int type) {
		Stats heroStats = EventController.hero.getStats();
		Stats enemyStats = EventController.enemy.getStats();
		int enemyAttackRegion = Random.Range ((int)region.chest, (int)region.right_leg);
		int enemyDefRegion = Random.Range ((int)region.chest, (int)region.right_leg);
		Debug.Log ("New fight step with type = " + type);

		switch (type) {
		case (int)attackType.meele:
			Debug.Log ("Fight. Step. Meele.");
			BattleEventController.toAttack (true);
			hit (EventController.hero, EventController.enemy, BattleEventController.heroAttackRegion, enemyDefRegion);
			BattleEventController.setReady (false);
			break;

		case (int)attackType.magic:
			BattleEventController.toMagic (true);
			magicHit (EventController.enemy);
			BattleEventController.setReady (false);
			break;

		default:
			Debug.Log ("Error! Wrong attack type");
			break;
		}

		while (GameObject.FindGameObjectWithTag ("Hero").GetComponent<ToStay> ().isReady () 
			|| GameObject.FindGameObjectWithTag ("Enemy").GetComponent<ToStay> ().isReady ()) {
			int i;
			i = 1;
			i += 1;
		}

		BattleEventController.toAttack (false); //не выполняется?
		hit (EventController.enemy, EventController.hero, enemyAttackRegion, BattleEventController.heroAttackRegion);

		if (EventController.hero.getAffect ((int)affect.poison).time > 0) {
			BattleEventController.updHealth (EventController.hero.getAffect ((int)affect.poison).value, EventController.hero);
			EventController.hero.decAffectTime ((int)affect.poison);
		}
		if (EventController.enemy.getAffect ((int)affect.poison).time > 0) {
			BattleEventController.updHealth (EventController.enemy.getAffect ((int)affect.poison).value, EventController.enemy);
			EventController.enemy.decAffectTime ((int)affect.poison);
		}

		BattleEventController.toDefault ();
	}

	public static void hit (Unit onAt, Unit onDef, int attackRegion, int defRegion) {
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

			if (attackRegion == defRegion)
				damage -= resist;
			else
				damage -= resist / 2;

		}
		Debug.Log ("final damage" + damage);
		BattleEventController.updHealth (-damage, onDef);
	}

	public static void magicHit (Unit onDef) {
		BattleEventController.updHealth (-5, onDef);
	}
}

//unit.getStats ().UpdCurPoints ((int)statName.health, damage);