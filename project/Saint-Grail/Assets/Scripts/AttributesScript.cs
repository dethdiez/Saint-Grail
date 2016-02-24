using UnityEngine;
using System.Collections;

namespace statistics
{
	enum attrName {strength, armor, faith, vitality};

	public class AttributesScript : MonoBehaviour {

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

		public void UpdAtt (attrName name, float upd){
			attribute [(int)name] += upd;
		}
	
		// Update is called once per frame
		void Update () {
			for (attrName i = attrName.strength; i < attrName.vitality; i++)
				UpdAtt (i, 0.0);
		}

		private float[] attribute;

	}
}