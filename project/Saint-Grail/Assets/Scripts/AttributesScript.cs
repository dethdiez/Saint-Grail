using UnityEngine;
using System.Collections;

namespace statistics
{
	

	public class AttributesScript : MonoBehaviour {

		public enum attrName {strength, armor, faith, vitality};

		// Use this for initialization
		void Start () {
			attribute = new float[4];
			NewAtt ();
		}

		public void NewAtt (float str=0, float arm=0, float fai=0, float vit=0){
			attribute [(int)attrName.strength] = str;
			attribute [(int)attrName.armor] = arm;
			attribute [(int)attrName.faith] = fai;
			attribute [(int)attrName.vitality] = vit;
		}

		//public void UpdAtt (int i, float upd){
		//	attribute [i] += upd;
		//}
	
		// Update is called once per frame
		void Update () {
//			UpdAtt ((int)attrName.strength, 0.0);
//			UpdAtt ((int)attrName.armor, 0.0);
//			UpdAtt ((int)attrName.faith, 0.0);
//			UpdAtt ((int)attrName.vitality, 0.0);
		}

		private float[] attribute;

	}


}