using UnityEngine;
using System.Collections;

public class FieldCreator : MonoBehaviour {

	private int[][] field;
	public GameObject[] enemy;
	public GameObject stone;

	// Use this for initialization
	void Start () {
		for (int i = 0; i<2; i++) {
			GameObject enemyClone;
			Vector3 pos = new Vector3 (-7.4f + (0.3f * 3 * i), -3.9f, 0);
			enemyClone = Instantiate (enemy[i], pos, Quaternion.identity) as GameObject;
		}
		GameObject stoneClone;
		Vector3 stPos = new Vector3 (-7.4f, -3.9f + 0.9f, 0);
		stoneClone = Instantiate (stone, stPos, Quaternion.identity) as GameObject;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
