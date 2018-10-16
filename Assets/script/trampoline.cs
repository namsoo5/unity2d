using UnityEngine;
using System.Collections;

public class trampoline : MonoBehaviour {
	GameObject player;
	// Use this for initialization
	void Start () {
		this.player = GameObject.Find ("cat");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "Player") {
			if (player.GetComponent<Rigidbody2D> ().velocity.y != 0) {
				player.GetComponent<Rigidbody2D> ().AddForce (transform.up * 800.0f);
			}
		}
	}
}
