using UnityEngine;
using System.Collections;

public enum effect {vampirism, dazzle, poison, concentrating, breakout, divineTear};
public enum affect {missing, poison, regeneration};

public class Effects : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	float vampirism (float damage) {
		return damage * 0.1f;
	}

	void dazzle (Unit defence) {
		if (Random.Range (0.0f, 100.0f) <= 10.0f) {
			EventController.setAffect (defence, (int)affect.missing, 2, 65.0f);
		}
			
	}

}
