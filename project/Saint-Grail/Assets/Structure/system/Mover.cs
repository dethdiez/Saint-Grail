using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour {

	public Vector2 speed = new Vector2 (2, 2);
	private Vector2 movement;
	private float angle;
	private float lastAngle;
	private Vector3 target;
	private Animator anim;
	private bool isMove;

	// Use this for initialization
	void Start () {
		angle = lastAngle = 0;
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		float inputX = Input.GetAxis("Horizontal");
		float inputY = Input.GetAxis("Vertical");
		movement = new Vector2 (speed.x * inputX, speed.y * inputY);
		isMove = (Mathf.Abs (movement.x) > 0) || (Mathf.Abs (movement.y) > 0);
		anim.SetBool ("isMoving", isMove);
		if (inputY > 0) {
			angle = -inputX * 45;
		} else if (inputY == 0) {
			angle = -inputX * 90;
		} else if (inputY < 0) {
			angle = 180 + inputX * 45;
		}
	}

	void FixedUpdate() {
		GetComponent<Rigidbody2D>().MoveRotation (angle);

		isMove = (Mathf.Abs (movement.x) > 0) || (Mathf.Abs (movement.y) > 0);
		anim.SetBool ("isMoving", isMove);
		//float absSpeed = 0;
		//absSpeed = Mathf.Sqrt (Mathf.Pow (movement.x, 2) + Mathf.Pow (movement.y, 2));
		//anim.SetFloat ("Speed", absSpeed);

		GetComponent<Rigidbody2D>().velocity = movement;

	}
}