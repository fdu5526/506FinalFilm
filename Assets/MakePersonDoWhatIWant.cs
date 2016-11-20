using UnityEngine;
using System.Collections;

public class MakePersonDoWhatIWant : MonoBehaviour {
	[SerializeField] Animator m_Anim;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void PlayWalk(){
		m_Anim.Play ("Basic_Walk_01");
	}

	void PlayIdle(){
		m_Anim.SetBool ("IsWalkToIdle", true);
	}

	void PlayWalkFromIdle(){
		m_Anim.SetBool ("IsWalkToIdle", false);
	}

}
