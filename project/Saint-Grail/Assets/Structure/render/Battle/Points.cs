using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using Statistics;

public class Points : MonoBehaviour {

	public GameObject health;
	public GameObject energy;
	public GameObject attack;
	public GameObject defence;
	public Stats stats;

	// Use this for initialization
	void Start () {
		health.GetComponent<Text> ().text = stats.GetCurPoints ((int)statName.health).ToString ("R")
			+ "/" + stats.GetStat ((int)statName.health).ToString ("R");
		energy.GetComponent<Text> ().text = stats.GetCurPoints ((int)statName.energy).ToString ("R")
			+ "/" + stats.GetStat ((int)statName.energy).ToString ("R");
		attack.GetComponent<Text> ().text = stats.GetStat ((int)statName.damage).ToString("R");
		defence.GetComponent<Text> ().text = stats.GetStat ((int)statName.resist).ToString("R");
	}
	
	// Update is called once per frame
	void Update () {
		health.GetComponent<Text> ().text = stats.GetCurPoints ((int)statName.health).ToString("R") 
			+ "/" + stats.GetStat ((int)statName.health).ToString("R");
		energy.GetComponent<Text> ().text = EventController.hero.getStats ().GetCurPoints ((int)statName.energy).ToString("R") 
			+ "/" + stats.GetStat ((int)statName.energy).ToString("R");
		attack.GetComponent<Text> ().text = stats.GetStat ((int)statName.damage).ToString("R");
		defence.GetComponent<Text> ().text = stats.GetStat ((int)statName.resist).ToString("R");
	}
}
