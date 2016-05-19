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
		Debug.Log ("Fight step. Enemy attack region = " + enemyAttackRegion.ToString ());
		Debug.Log ("Fight step. Enemy defence region = " + enemyDefRegion.ToString ());

		BattleEventController.toDefault ();

		switch (type) {

		case (int)attackType.meele:
			Debug.Log ("Fight. Step. Meele.");
			BattleEventController.toAttack (true);
			hit (EventController.hero, EventController.enemy, BattleEventController.heroAttackRegion, enemyDefRegion);
//			BattleEventController.setReady (false);
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

		if (EventController.enemy.getAffect ((int)affect.poison).time > 0) {
			BattleEventController.updHealth (EventController.enemy.getAffect ((int)affect.poison).value, EventController.enemy);
			EventController.enemy.decAffectTime ((int)affect.poison);
		}
			
		Debug.Log ("Fight! Current health = " + enemyStats.GetCurPoints ((int)statName.health));
		if (enemyStats.GetCurPoints ((int)statName.health) == 0.0f) {
			BattleEventController.toDeath (false);
		} else {
			BattleEventController.toAttack (false);
			hit (EventController.enemy, EventController.hero, enemyAttackRegion, BattleEventController.heroAttackRegion);

			Debug.Log ("EventControler hero time = " + EventController.hero.getAffect ((int)affect.poison).time);
			Debug.Log ("EventControler hero time = " + EventController.enemy.getAffect ((int)affect.poison).time);
			if (EventController.hero.getAffect ((int)affect.poison).time > 0) {
				BattleEventController.updHealth (EventController.hero.getAffect ((int)affect.poison).value, EventController.hero);
				EventController.hero.decAffectTime ((int)affect.poison);
			}

			if (heroStats.GetCurPoints ((int)statName.health) == 0) {
				BattleEventController.toDeath (true);
			}
		}
	}

	public static void hit (Unit onAt, Unit onDef, int attackRegion, int defRegion) {
		Debug.Log ("Hit!");
		float damage = onAt.getStats ().GetStat ((int)statName.damage);
		Debug.Log ("Default damage " + damage);
		bool isMiss = false;
		bool isGodsHelp = false;

		if (onAt.getAffect ((int)affect.missing).time > 0) {
			isMiss = Effects.miss ();
			onAt.decAffectTime ((int)affect.missing);
			Debug.Log ("wtf 1");
		} else if (onDef.getEffect ((int)effect.divineTear)) {
			isGodsHelp = Effects.divineTear ();
			Debug.Log ("wtf 2");
		}

		if (isMiss || isGodsHelp) {
			damage = 0;
			Debug.Log ("wtf 3");
		} else {
			float resist = onDef.getStats ().GetStat ((int)statName.resist);

			if (onAt.getEffect ((int)effect.breakout)) {
				if (Effects.breakout ()) {
					resist = resist / 2;
				}

				Debug.Log ("wtf 5");
			}

			if (onAt.getEffect ((int)effect.concentrating)) {
				if (Effects.concentrating ()) {
					damage = damage * 2;
				}
				Debug.Log ("wtf 6");
			}

			if (onAt.getEffect ((int)effect.dazzle)) {
				Effects.dazzle (onDef);
				Debug.Log ("wtf 7");
			}
		
			if (onAt.getEffect ((int)effect.poison)) {
				Effects.poison (onDef, damage);
				Debug.Log ("wtf 8");
			}

			if (onAt.getEffect ((int)effect.vampirism)) {
				BattleEventController.updHealth (Effects.vampirism (damage), onAt);
				Debug.Log ("wtf 9");
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