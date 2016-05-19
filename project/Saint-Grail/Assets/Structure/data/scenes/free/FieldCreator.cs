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
			setObj (stone, 1, 1);
			setObj (stone, 1, 2);
			setObj (stone, 1, 3);
			setObj (stone, 1, 4);
			setObj (stone, 1, 5);
			setObj (stone, 1, 6);
			setObj (stone, 1, 8);
			setObj (stone, 1, 9);
			setObj (stone, 1, 10);
			setObj (stone, 1, 11);
			setObj (stone, 1, 12);
			setObj (stone, 1, 13);
			setObj (stone, 1, 14);
			setObj (stone, 2, 1);
			setObj (stone, 2, 14);
			setObj (stone, 2, 6);
			setObj (stone, 2, 8);
			setObj (stone, 3, 1);
			setObj (stone, 3, 3);
			setObj (stone, 3, 4);
			setObj (stone, 3, 6);
			setObj (stone, 3, 8);
			setObj (stone, 3, 10);
			setObj (stone, 3, 11);
			setObj (stone, 3, 12);
			setObj (stone, 3, 14);
			setObj (stone, 4, 1);
			setObj (stone, 4, 3);
			setObj (stone, 4, 4);
			setObj (stone, 4, 6);
			setObj (stone, 4, 8);
			setObj (stone, 4, 10);
			setObj (stone, 4, 12);
			setObj (stone, 4, 14);
			setObj (stone, 5, 1);
			setObj (stone, 5, 3);
			setObj (stone, 5, 4);
			setObj (stone, 5, 6);
			setObj (stone, 5, 8);
			setObj (stone, 5, 10);
			setObj (stone, 5, 12);
			setObj (stone, 5, 14);
			setObj (stone, 6, 1);
			setObj (stone, 6, 3);
			setObj (stone, 6, 4);
			setObj (stone, 6, 12);
			setObj (stone, 6, 14);
			setObj (stone, 7, 1);
			setObj (stone, 7, 3);
			setObj (stone, 7, 4);
			setObj (stone, 7, 5);
			setObj (stone, 7, 6);
			setObj (stone, 7, 7);
			setObj (stone, 7, 8);
			setObj (stone, 7, 9);
			setObj (stone, 7, 10);
			setObj (stone, 7, 11);
			setObj (stone, 7, 12);
			setObj (stone, 7, 14);
			setObj (stone, 8, 1);
			setObj (stone, 8, 3);
			setObj (stone, 8, 14);
			setObj (stone, 9, 1);
			setObj (stone, 9, 3);
			setObj (stone, 9, 5);
			setObj (stone, 9, 6);
			setObj (stone, 9, 7);
			setObj (stone, 9, 9);
			setObj (stone, 9, 10);
			setObj (stone, 9, 11);
			setObj (stone, 9, 12);
			setObj (stone, 9, 13);
			setObj (stone, 9, 14);
			setObj (stone, 10, 1);
			setObj (stone, 10, 3);
			setObj (stone, 10, 5);
			setObj (stone, 10, 6);
			setObj (stone, 10, 7);
			setObj (stone, 10, 9);
			setObj (stone, 10, 14);
			setObj (stone, 11, 1);
			setObj (stone, 11, 3);
			setObj (stone, 11, 9);
			setObj (stone, 11, 11);
			setObj (stone, 11, 12);
			setObj (stone, 11, 14);
			setObj (stone, 12, 1);
			setObj (stone, 12, 3);
			setObj (stone, 12, 4);
			setObj (stone, 12, 5);
			setObj (stone, 12, 7);
			setObj (stone, 12, 8);
			setObj (stone, 12, 9);
			setObj (stone, 12, 12);
			setObj (stone, 12, 14);
			setObj (stone, 13, 1);
			setObj (stone, 13, 3);
			setObj (stone, 13, 9);
			setObj (stone, 13, 12);
			setObj (stone, 13, 14);
			setObj (stone, 14, 1);
			setObj (stone, 14, 3);
			setObj (stone, 14, 4);
			setObj (stone, 14, 5);
			setObj (stone, 14, 7);
			setObj (stone, 14, 9);
			setObj (stone, 14, 12);
			setObj (stone, 14, 14);
			setObj (stone, 15, 1);
			setObj (stone, 15, 3);
			setObj (stone, 15, 5);
			setObj (stone, 15, 9);
			setObj (stone, 15, 7);
			setObj (stone, 15, 12);
			setObj (stone, 15, 14);
			setObj (stone, 16, 1);
			setObj (stone, 16, 3);
			setObj (stone, 16, 5);
			setObj (stone, 16, 9);
			setObj (stone, 16, 7);
			setObj (stone, 16, 12);
			setObj (stone, 16, 14);
			setObj (stone, 17, 1);
			setObj (stone, 17, 3);
			setObj (stone, 17, 5);
			setObj (stone, 17, 9);
			setObj (stone, 17, 7);
			setObj (stone, 17, 11);
			setObj (stone, 17, 10);
			setObj (stone, 17, 12);
			setObj (stone, 17, 14);
			setObj (stone, 18, 1);
			setObj (stone, 18, 7);
			setObj (stone, 19, 1);
			setObj (stone, 19, 2);
			setObj (stone, 19, 3);
			setObj (stone, 19, 4);
			setObj (stone, 19, 5);
			setObj (stone, 19, 6);
			setObj (stone, 19, 7);
			setObj (stone, 19, 8);
			setObj (stone, 19, 9);
			setObj (stone, 19, 10);
			setObj (stone, 19, 11);
			setObj (stone, 19, 12);
			setObj (stone, 19, 13);
			setObj (stone, 19, 14);
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
