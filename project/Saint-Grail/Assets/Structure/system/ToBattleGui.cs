using UnityEngine;
using System.Collections;

public class ToBattleGui : MonoBehaviour {

	private static bool isRendering = false;
	public bool fuck = false;

	// Use this for initialization
	void Start () {
	
	}

	void OnGUI () {
		if (isRendering) {
			GUI.Box (new Rect (Screen.width / 2 - 50, Screen.height / 2 - 140, 100, 40), "Start Battle?");
			if (GUI.Button (new Rect (Screen.width / 2 - 25, Screen.height / 2 - 60, 50, 40), "Yes")) {
				fuck = true;
				Application.LoadLevel ("Battle");
//				UnityEngine.SceneManagement.SceneManager.LoadScene ("Battle");
				isRendering = false;
			}
			if (GUI.Button(new Rect(Screen.width / 2 - 25, Screen.height / 2 + 20, 50, 40), "NO")) {
				isRendering = false;
			}
		}
	}

	public static void showWindow() {
		isRendering = true;
	}

	// Update is called once per frame
	void Update () {

	}
}
