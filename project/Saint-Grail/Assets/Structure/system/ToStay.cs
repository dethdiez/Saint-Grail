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
		Debug.Log ("ToStay. Unit name " + gameObject.name + " isAttack = " + animator.GetBool("isAttack"));
		Debug.Log ("End of branch.");
	}

	public void toMagic() {
		Debug.Log ("Magic! Unit with tag " + gameObject.tag);
		animator.SetBool ("isMagic", true);
		Debug.Log ("End of branch.");
	}

	public void toDeath() {
		animator.SetBool ("isDeath", true);
	}

	public void setReady () {
		Debug.Log ("set ready to true");
		BattleEventController.setReady (true);
		isTrue = true;
	}

	public void setNotReady () {
		Debug.Log ("set not ready to true");
		BattleEventController.setReady (false);
		isTrue = false;
	}

	public bool isReady () {
		return isTrue;
	}

	public void death() {

	}

	private bool isTrue;
}
