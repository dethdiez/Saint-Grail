using UnityEngine;
using System.Collections;

namespace Statistics
{
	public enum statName {health, energy, damage, resist, luck};
	public enum heroType {jungle, punisher, knight};

	public class Stats : MonoBehaviour {

		// Use this for initialization
		void Start () {
			stat = new float[4];
			NewStats ();
		}

		public void NewStats (float dam=0, float res=0, float hp=0, float ep=0, float lp=0){
			stat [(int)statName.damage] = dam;
			stat [(int)statName.resist] = res;
			stat [(int)statName.health] = hp;
			stat [(int)statName.energy] = ep;
			stat [(int)statName.luck]   = lp;
			curPoints [(int)statName.health] = hp;
			curPoints [(int)statName.energy] = ep;
		}

		public void UpdStat (int name, float upd){
			stat [name] += upd;
			if (stat [name] < 0)
				stat [name] = 0;
		}

		public void UpdCurPoints (int name, float upd){
			curPoints [name] += upd;
			if (curPoints [name] > stat [name])
				curPoints [name] = stat [name];
			if (curPoints [name] < 0)
				curPoints [name] = 0;
		}
	
		//Update is called once per frame
		void Update () {
			UpdStat ((int)statName.damage, 0);
			UpdStat ((int)statName.resist, 0);
			UpdStat ((int)statName.health, 0);
			UpdStat ((int)statName.energy, 0);
			UpdStat ((int)statName.luck,   0);
			UpdCurPoints ((int)statName.health, 0);
			UpdCurPoints ((int)statName.energy, 0);
		}

		public float GetStat(int name) {
			return stat [name];
		}

		public void setDefaultStats (int t) {
			switch (t) {
			case (int)heroType.jungle:
				NewStats (9, 4, 30, 10, 2);
				break;

			case (int)heroType.knight:
				NewStats (13, 4, 42, 5, 1);
				break;

			case (int)heroType.punisher:
				NewStats (6, 6, 10, 60, 2);
				break;

			default:
				Debug.Log ("Error: incorrect type of hero");
				break;
			}
		}

		protected float[] stat;
		protected float[] curPoints;
	}
}