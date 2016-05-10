using UnityEngine;
using System.Collections;

public class FieldCreator : MonoBehaviour {

	private int[][] field;
	public GameObject[] enemy;
	public GameObject stone;

	// Use this for initialization
	void Start () {
		field = new int[19][];
		for (int i = 0; i < 19; i++)
			field [i] = new int[14];
		loadField (0);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void loadField (int id) {
		switch (id) {

		case 1:
			break;

		default:
			for (int i = 0; i < 2; i++) {
				GameObject enemyClone;
				Vector3 pos = new Vector3 (-7.4f + (0.3f * 3 * i), -3.9f, 0);
				enemyClone = Instantiate (enemy [i], pos, Quaternion.identity) as GameObject;
			}
			GameObject stoneClone;
			Vector3 stPos = new Vector3 (-7.4f, -3.9f + 0.9f, 0);
			stoneClone = Instantiate (stone, stPos, Quaternion.identity) as GameObject;
			break;
		}
	}
}
