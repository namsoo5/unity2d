using UnityEngine;
using System.Collections;

public class change : MonoBehaviour {
	GameObject cat;
	bool drop = true;
	// Use this for initialization
	void Start () {
		this.cat = GameObject.Find ("cat");
	
	}
	
	// Update is called once per frame
	void Update () {
		if (drop) {
			gameObject.SetActive (true);
			GetComponent<Rigidbody2D> ().AddForce (transform.up * 250f);  //item drop motion
			drop = false;
		}

	}
	void OnCollisionEnter2D(Collision2D other){
		if (other.gameObject.tag == "Player") {
			cat.GetComponent<PlayerController> ().change = true;
			gameObject.SetActive (false);
		}

	}
}
