using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LevelManager : MonoBehaviour {

	Animator animator;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp("r")) {
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		} else if (Input.GetKeyUp("n")) {
			animator.Play("SceneBridge_Shot12");
		}
	}
}
