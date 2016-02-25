using UnityEngine;
using System.Collections;

namespace statistics
{
	public enum statName {damage, resist, health, energy};

	public class StatScript : MonoBehaviour {

		// Use this for initialization
		void Start () {
			stat = new float[4];
			NewStats ();
		}

		public void NewStats (float str=0, float arm=0, float fai=0, float vit=0){
			stat [(int)statName.damage] = str;
			stat [(int)statName.resist] = arm;
			stat [(int)statName.health] = fai;
			stat [(int)statName.energy] = vit;
		}

		public void UpdStat (int name, float upd){
			stat [name] += upd;
		}
	
		//Update is called once per frame
		void Update () {
			UpdStat ((int)statName.damage, 0);
			UpdStat ((int)statName.resist, 0);
			UpdStat ((int)statName.health, 0);
			UpdStat ((int)statName.energy, 0);
		}

		public float GetStat(int name) {
			return stat [name];
		}

		protected float[] stat;
	}
}