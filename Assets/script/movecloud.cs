using UnityEngine;
using System.Collections;

public class movecloud : MonoBehaviour {
	bool up = false;
	bool down =false;
	int num=0;
	GameObject cat;
	// Use this for initialization
	void Start () {
		this.cat = GameObject.Find ("cat");
	}
	
	// Update is called once per frame
	void Update () {

		if (up && !down) {
			this.transform.Translate (0, 0.02f, 0);
			num++;
			if (num > 100) {
				up = false;
			}
		}
		else if (down) {
			up = false;
			this.transform.Translate (0, -0.02f, 0);
			num--;
			if (num <= 0) {
				down = false;
			}
				
		}

	}
	void OnCollisionEnter2D(Collision2D other){
		if (other.gameObject.tag == "Player") {
			up = true;
		}
	}
	void OnCollisionExit2D(Collision2D other){
		if (other.gameObject.tag == "Player") {
			down = true;
		}
	}



}
