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

	public static void step(Hero hero, Enemy enemy) {

	}

	public static void hit (Unit onAt, Unit onDef) {
		float damage = onAt.getStats ().GetCurPoints ((int)statName.damage);
		bool isMiss = false;
		bool isGodsHelp = false;

		if (onAt.getAffect ((int)affect.missing).time > 0) {
			isMiss = Effects.miss ();
			if (isMiss)
				onAt.decAffectTime ((int)affect.missing);
		} else if (onDef.getEffect ((int)effect.divineTear)) {
			isGodsHelp = Effects.divineTear ();
		}

		if (isMiss || isGodsHelp) {
			damage = 0;
		} else {
			float resist = onDef.getStats ().GetCurPoints ((int)statName.resist);

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
				BattleEventController.updHealth (Effects.vampirism (damage), onDef);
			}
		}

		BattleEventController.updHealth (-damage, onDef);
	}
}

//unit.getStats ().UpdCurPoints ((int)statName.health, damage);