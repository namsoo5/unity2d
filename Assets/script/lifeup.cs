﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class lifeup : MonoBehaviour {
	bool drop = true;
	GameObject life;
	GameObject dropsound;
	// Use this for initialization
	void Start () {
		this.life = GameObject.Find ("heart");
		this.dropsound = GameObject.Find ("itemdropsound");
	}
	
	// Update is called once per frame
	void Update () {
		if (drop) {
			gameObject.SetActive (true);
			GetComponent<Rigidbody2D> ().AddForce (transform.up * 250f);   //drop motion
			drop = false;
		}
	}
	void OnCollisionEnter2D(Collision2D other){
		if (other.gameObject.tag == "Player") {
			life.GetComponent<life> ().heal ();
			this.dropsound.GetComponent<dropsound> ().startmusic ();
			gameObject.SetActive (false);
		}

	}
}
