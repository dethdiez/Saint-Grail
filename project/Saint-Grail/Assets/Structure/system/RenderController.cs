using UnityEngine;
using System.Collections;

public class RenderController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public static void lockScene (bool doIt) {
		Mover.lockScene (doIt);
	}
}
