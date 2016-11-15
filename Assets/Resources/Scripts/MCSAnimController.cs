using UnityEngine;
using System.Collections;

public class MCSAnimController : MonoBehaviour {

	private Animator anim;
	private float run;


	public enum AnimationState { Idle, Interacting, Running, Sprinting, Turn90, Turn180 };


	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		run = 0.0f;
	}


	public void SetAnimatorState (AnimationState state) {

	}
	
	// Update is called once per frame
	void Update () {
		run = Input.GetAxis("Horizontal");
		anim.SetFloat ("run", run);
	}
}
