using UnityEngine;
using System.Collections;

public class movecloud : MonoBehaviour {
	float high=0;
	GameObject cat;
	// Use this for initialization
	void Start () {
		this.cat = GameObject.Find ("cat");
	}
	
	// Update is called once per frame
	void Update () {
		high += Time.deltaTime;

		if (high < 3) {
			this.transform.Translate (0, -0.02f, 0);
		} else if (high >= 3) {
			this.transform.Translate (0, 0.02f, 0);
			if (high > 6)
				high = 0;
		}

	}
	void OnCollisionEnter2D(Collision2D other){
		if (other.gameObject.tag == "Player") {
			cat.GetComponent<PlayerController> ().jump = true;
		}
	}
	void OnCollisionExit2D(Collision2D other){
		if (other.gameObject.tag == "Player") {
			cat.GetComponent<PlayerController> ().jump = false;
		}
	}
}
