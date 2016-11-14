using UnityEngine;
using System.Collections;

public class MCSAnimController : MonoBehaviour {

	private Animator anim;
	private float run;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		run = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
		run = Input.GetAxis("Horizontal");
		anim.SetFloat ("run", run);
	}
}
