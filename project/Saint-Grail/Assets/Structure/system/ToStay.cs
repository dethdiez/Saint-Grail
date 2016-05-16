using UnityEngine;
using System.Collections;

public class ToStay : MonoBehaviour {

	public Animator animator;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void toStay() {
		animator.SetBool (0, false);
		animator.SetBool (1, false);
		animator.SetBool (2, false);
	}

	public void toAttack() {
		animator.SetBool (0, true);
	}

	public void toMagic() {
		animator.SetBool (1, true);
	}

	public void toDeath() {
		animator.SetBool (2, true);
	}

	public void setReady () {
		BattleEventController.setReady (true);
	}

	public void setNotReady () {
		BattleEventController.setReady (false);
	}
}
