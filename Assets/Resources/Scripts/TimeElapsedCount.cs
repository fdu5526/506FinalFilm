using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TimeElapsedCount : MonoBehaviour {

	Text text;

	// Use this for initialization
	void Start () {
		text = GetComponent<Text>();
		text.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		text.text = Time.time + "";
	}
}
