using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public enum ItemName {energy, health, mushroom, drop, bone, gold, scroll, enchantP, enchantJ, enchantK}

public class Inventory : MonoBehaviour {

	// Use this for initialization
	void Start () {
		item = new int[10];
		GameObject[] o = GameObject.FindGameObjectsWithTag ("Item");
		for (int i = 0; i<10; i++) {
			item [i] = 0;
			Debug.Log ("Start Inventory. object " + i + " named " + o [i].name);
			setItemAmount (o [i], 0);
		}
	}
	
	// Update is called once per frame
	void Update () {
		GameObject[] o = GameObject.FindGameObjectsWithTag ("Item");
		for (int i = 0; i<10; i++) {
			if(isExist(i))
				setItemAmount(o[i], item[i]);
		}
	}

	public static void updItemAmount (int name, int upd) {
		item [name] += upd;
	}

	public static void setItemAmount (GameObject obj, int amount) {
		obj.GetComponentInChildren<Text> ().text = amount.ToString ();
	}

	public static bool isExist(int name) {
		return (item [name] > 0);
	}

	private static int[] item;
}
