using UnityEngine;
using System.Collections;

public class FieldCreator : MonoBehaviour {

	private int[,] field;
	public GameObject[] enemy;
	public GameObject chest;
	public GameObject stone;
	public GameObject hero;
	public GameObject[] item;

	public static bool isRendered;

	// Use this for initialization
	void Awake () {
		field = new int[19,14];
		if (!isRendered)
			loadField (fieldNumber);
		else
			Destroy (GameObject.Find ("monster_1(Clone)"));


		EventController.hero = hero.GetComponent<Hero>();
//		Debug.Log (EventController.hero.getStats ().GetStat (0));
	}
	
	// Update is called once per frame
	void Update () {
		if (hero.GetComponent<Transform> ().position.x > 1)
			setObj (stone, 10, 1);
	}

	public void loadField (int id) {
		isRendered = true;

		switch (id) {

		case 1:
			setObj (stone, 0, 0);
			setObj (stone, 0, 1);
			setObj (stone, 0, 2);
			setObj (stone, 0, 3);
			setObj (stone, 0, 4);
			setObj (stone, 0, 5);
			setObj (stone, 0, 7);
			setObj (stone, 0, 8);
			setObj (stone, 0, 9);
			setObj (stone, 0, 10);
			setObj (stone, 0, 11);
			setObj (stone, 0, 12);
			setObj (stone, 0, 13);
			setObj (stone, 1, 0);
			setObj (stone, 1, 13);
			setObj (stone, 1, 5);
			setObj (stone, 1, 7);
			setObj (stone, 2, 0);
			setObj (stone, 2, 2);
			setObj (stone, 2, 3);
			setObj (stone, 2, 5);
			setObj (stone, 2, 7);
			setObj (stone, 2, 9);
			setObj (stone, 2, 10);
			setObj (stone, 2, 11);
			setObj (stone, 2, 13);
			setObj (stone, 3, 0);
			setObj (stone, 3, 2);
			setObj (stone, 3, 3);
			setObj (stone, 3, 5);
			setObj (stone, 3, 7);
			setObj (stone, 3, 9);
			setObj (stone, 3, 11);
			setObj (stone, 3, 13);
			setObj (stone, 4, 0);
			setObj (stone, 4, 3);
			setObj (stone, 4, 2);
			setObj (stone, 4, 5);
			setObj (stone, 4, 7);
			setObj (stone, 4, 9);
			setObj (stone, 4, 11);
			setObj (stone, 4, 13);
			setObj (stone, 5, 0);
			setObj (stone, 5, 3);
			setObj (stone, 5, 2);
			setObj (stone, 5, 11);
			setObj (stone, 5, 13);
			setObj (stone, 6, 0);
			setObj (stone, 6, 3);
			setObj (stone, 6, 4);
			setObj (stone, 6, 5);
			setObj (stone, 6, 6);
			setObj (stone, 6, 7);
			setObj (stone, 6, 8);
			setObj (stone, 6, 9);
			setObj (stone, 6, 10);
			setObj (stone, 6, 11);
			setObj (stone, 6, 2);
			setObj (stone, 6, 13);
			setObj (stone, 7, 0);
			setObj (stone, 7, 2);
			setObj (stone, 7, 13);
			setObj (stone, 8, 0);
			setObj (stone, 8, 2);
			setObj (stone, 8, 5);
			setObj (stone, 8, 6);
			setObj (stone, 8, 4);
			setObj (stone, 8, 9);
			setObj (stone, 8, 10);
			setObj (stone, 8, 11);
			setObj (stone, 8, 12);
			setObj (stone, 8, 13);
			setObj (stone, 8, 8);
			setObj (stone, 9, 0);
			setObj (stone, 9, 2);
			setObj (stone, 9, 5);
			setObj (stone, 9, 6);
			setObj (stone, 9, 4);
			setObj (stone, 9, 8);
			setObj (stone, 9, 13);
			setObj (stone, 10, 0);
			setObj (stone, 10, 2);
			setObj (stone, 10, 8);
			setObj (stone, 10, 11);
			setObj (stone, 10, 10);
			setObj (stone, 10, 13);
			setObj (stone, 11, 0);
			setObj (stone, 11, 3);
			setObj (stone, 11, 4);
			setObj (stone, 11, 2);
			setObj (stone, 11, 7);
			setObj (stone, 11, 6);
			setObj (stone, 11, 8);
			setObj (stone, 11, 11);
			setObj (stone, 11, 13);
			setObj (stone, 12, 0);
			setObj (stone, 12, 2);
			setObj (stone, 12, 8);
			setObj (stone, 12, 11);
			setObj (stone, 12, 13);
			setObj (stone, 13, 0);
			setObj (stone, 13, 3);
			setObj (stone, 13, 4);
			setObj (stone, 13, 2);
			setObj (stone, 13, 6);
			setObj (stone, 13, 8);
			setObj (stone, 13, 11);
			setObj (stone, 13, 13);
			setObj (stone, 14, 0);
			setObj (stone, 14, 2);
			setObj (stone, 14, 4);
			setObj (stone, 14, 8);
			setObj (stone, 14, 6);
			setObj (stone, 14, 11);
			setObj (stone, 14, 13);
			setObj (stone, 15, 0);
			setObj (stone, 15, 2);
			setObj (stone, 15, 4);
			setObj (stone, 15, 8);
			setObj (stone, 15, 6);
			setObj (stone, 15, 11);
			setObj (stone, 15, 13);
			setObj (stone, 16, 0);
			setObj (stone, 16, 2);
			setObj (stone, 16, 4);
			setObj (stone, 16, 8);
			setObj (stone, 16, 6);
			setObj (stone, 16, 10);
			setObj (stone, 16, 9);
			setObj (stone, 16, 11);
			setObj (stone, 16, 13);
			setObj (stone, 17, 0);
			setObj (stone, 17, 6);
			setObj (stone, 18, 1);
			setObj (stone, 18, 2);
			setObj (stone, 18, 3);
			setObj (stone, 18, 4);
			setObj (stone, 18, 5);
			setObj (stone, 18, 6);
			setObj (stone, 18, 7);
			setObj (stone, 18, 0);
			setObj (stone, 18, 8);
			setObj (stone, 18, 9);
			setObj (stone, 18, 10);
			setObj (stone, 18, 11);
			setObj (stone, 18, 12);
			setObj (stone, 18, 13);
			setObj (enemy [0], 11, 5);


				
			break;

//		case 2:
//			int i;
//			setObj (hero, 10, 0);
//			for (i = 0; i <= 18; i++) {
//				if (i != 10)
//					setObj (stone, i, 0);
//				setObj (stone, i, 13);
//			}
//			for (i = 0; i <= 13; i++)
//				if (i != 6) {
//					setObj (stone, 0, i);
//					setObj (stone, 18, i);
//				}
//					
//			break;

		default:
			setObj (enemy [0], 0, 0);
			setObj (enemy [1], 2, 2);
			setObj (stone, 4, 4);

			break;
		}
	}

	public void setObj(GameObject obj, int x, int y) {
		GameObject Clone;
		Vector3 stPos = new Vector3 (-7.4f + x * 0.6f, -3.9f + y * 0.6f, 0);
		Clone = Instantiate (obj, stPos, Quaternion.identity) as GameObject;
		DontDestroyOnLoad (Clone);
	}

	public void destroyObj (GameObject obj) {
		Destroy (obj);
	}

	public static void setNumber (int num) {
		fieldNumber = num;
		Debug.Log ("New field for create, id = " + FieldCreator.fieldNumber);
	}

	private static int fieldNumber;
}
