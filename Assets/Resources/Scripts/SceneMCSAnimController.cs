using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class SceneMCSAnimController : MonoBehaviour {

	MCSAnimController personController;

	// Use this for initialization
	void Start () {
		personController = FindObjectOfType<MCSAnimController>();
	}


	public void SetPersonAnimatorState (MCSAnimController.AnimationState state) {
		personController.SetAnimatorState(state);
	}

	// Update is called once per frame
	void Update () {

	}
}
