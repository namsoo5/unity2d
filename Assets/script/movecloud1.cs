using UnityEngine;
using System.Collections;

public class movecloud1 : MonoBehaviour {
	float high;
	GameObject cat;
	// Use this for initialization
	void Start () {
		this.cat = GameObject.Find ("cat");
	}
	
	// Update is called once per frame
	void Update () {
		high += Time.deltaTime;

		if (high < 3) {
			this.transform.Translate (0, 0.03f, 0);
		} else if (high >= 3) {
			this.transform.Translate (0, -0.03f, 0);
			if (high > 6)
				high = 0;
		}
	}
}
