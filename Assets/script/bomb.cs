using UnityEngine;
using System.Collections;

public class bomb : MonoBehaviour {
	float move;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		move += Time.deltaTime;

		if (move < 2) {
			this.transform.Translate (0.04f, 0, 0);
		} else if (move >= 2) {
			this.transform.Translate (-0.04f,0, 0);
			if (move > 4)
				move = 0;
		}
	}
}
