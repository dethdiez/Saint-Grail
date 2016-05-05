using UnityEngine;
using System.Collections;

public class InsideMenu : MonoBehaviour {

	public GameObject insideMenu;

	// Use this for initialization
	void Start () {

		RectTransform menuTransform = insideMenu.GetComponent<RectTransform>();
		insideMenu.GetComponent<RectTransform> ().sizeDelta = new Vector2 (3.7f, 2);
		Debug.Log (insideMenu.GetComponent<RectTransform> ().rect.height);
//		menuTransform.rect.height = 2;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
