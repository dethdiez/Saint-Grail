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
		animator.SetBool ("isMagic", false);
		animator.SetBool ("isDeath", false);
	}
}
