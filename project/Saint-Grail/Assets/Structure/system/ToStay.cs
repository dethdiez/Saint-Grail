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
		animator.SetBool ("isAttack", false);
		animator.SetBool ("isDeath", false);
		animator.SetBool ("isMagic", false);
	}

	public void toAttack() {
		animator.SetBool ("isAttack", true);
	}

	public void toMagic() {
		Debug.Log ("Magic! Unit with tag " + gameObject.tag);
		animator.SetBool ("isMagic", true);
	}

	public void toDeath() {
		animator.SetBool ("isDeath", true);
	}

	public void setReady () {
		BattleEventController.setReady (true);
		isTrue = true;
	}

	public void setNotReady () {
		BattleEventController.setReady (false);
		isTrue = false;
	}

	public bool isReady () {
		return isTrue;
	}

	private bool isTrue;
}
