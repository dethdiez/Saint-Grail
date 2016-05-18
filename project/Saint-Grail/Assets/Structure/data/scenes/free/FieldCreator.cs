using UnityEngine;
using System.Collections;

public class FieldCreator : MonoBehaviour {

	private int[,] field;
	public GameObject[] enemy;
	public GameObject chest;
	public GameObject stone;
	public GameObject hero;
	public GameObject[] item;

	// Use this for initialization
	void Start () {
		field = new int[19,14];
		loadField (fieldNumber);

		EventController.hero = hero.GetComponent<Hero>();
//		Debug.Log (EventController.hero.getStats ().GetStat (0));
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void loadField (int id) {
		switch (id) {

		case 1:
			break;

		default:
			setObj (enemy [0], 0, 0);
			setObj (enemy [1], 2, 2);
			setObj (stone, 4, 4);

			break;
		}
	}

	public void setObj(GameObject obj, int x, int y) {
		GameObject stoneClone;
		Vector3 stPos = new Vector3 (-7.4f + x * 0.6f, -3.9f + y * 0.6f, 0);
		stoneClone = Instantiate (obj, stPos, Quaternion.identity) as GameObject;
	}

	public static void setNumber (int num) {
		fieldNumber = num;
	}

	private static int fieldNumber;
}
