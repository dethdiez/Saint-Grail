using UnityEngine;
using System.Collections;

//using statistics;

namespace Statistics
{
	public enum attrName {strength, armor, faith, vitality};

	public class Attributes : MonoBehaviour {

		// Use this for initialization
		void Start () {
			attribute = new float[4];
			NewAttributes ();
			experience = new Experience();
		}

		public void NewAttributes (float str = 0, float arm = 0, float fai = 0, float vit = 0) {
			attribute [(int)attrName.strength] = str;
			attribute [(int)attrName.armor] = arm;
			attribute [(int)attrName.faith] = fai;
			attribute [(int)attrName.vitality] = vit;
		}

		public void UpdAttribute (int name, float upd) {
			attribute [name] += upd;
		}

		//Update is called once per frame
		void Update () {
			UpdAttribute ((int)attrName.strength, 0);
			UpdAttribute ((int)attrName.armor, 0);
			UpdAttribute ((int)attrName.faith, 0);
			UpdAttribute ((int)attrName.vitality, 0);
		}

		public float GetAttr (int name) {
			return attribute [name];
		}
		public Experience GetExp () {
			return experience;
		}

		private float[] attribute;
		private Experience experience;
	}



	public class Experience {

		public Experience () {
			level = 0;
			exp = 0;
			shift = 100500;
		}

		public void UpdExp (float upd) {
			exp += upd;
			if (exp >= shift) {
				level++;
				exp = 0;
				shift = shift * level;
			}
		}

		public int GetLevel () {
			return level;
		}
		public float GetExp () {
			return exp;
		}

		private int level;
		private float exp;
		private int shift;
	}
}
