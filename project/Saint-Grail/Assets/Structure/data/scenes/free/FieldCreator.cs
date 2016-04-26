using UnityEngine;
using System.Collections;

public class FieldCreator : MonoBehaviour {

	public GameObject[] enemy;

	// Use this for initialization
	void Start () {
		for (int i = 0; i<2; i++) {
			GameObject enemyClone;
			Vector3 pos = new Vector3 (5 * i, i, 0);
			enemyClone = Instantiate (enemy[i], pos, Quaternion.identity) as GameObject;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
