using UnityEngine;
using System.Collections;

public class MCSAnimController : MonoBehaviour {

	private Animator animator;

	public enum AnimationState { Idle_Neutral_1, RunAvoid_ToLeft_Both, RunForward_NtrlFaceFwd, Roll_To_Run, Run_FastStop_Idle, PlantNTurn90_Run_R, PlantNTurn180_Run_R_1, SprintJump_ToLeft_R, Idle2walk_AllAngles, Idle2Run_AllAngles, WalkForward_NtrlFaceFwd, Run_Loop };

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
	}


	public void SetAnimatorState (AnimationState state) {
		animator.Play(state.ToString("G"), 0, 0f);

		transform.localPosition = Vector3.zero;
		transform.localEulerAngles = Vector3.zero;
	}
	
	// Update is called once per frame
	void Update () {
	}
}
