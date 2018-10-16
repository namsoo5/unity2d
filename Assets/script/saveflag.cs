using UnityEngine;
using System.Collections;
using UnityEngine.Audio;

public class saveflag : MonoBehaviour {
	GameObject limit;
	GameObject music1;
	GameObject music2;
	// Use this for initialization
	void Start () {
		this.limit = GameObject.Find("limitzonectrl");
		this.music1 = GameObject.Find ("startmusic");
		this.music2 = GameObject.Find ("savemusic");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "Player") {
			other.gameObject.GetComponent<PlayerController> ().save = true;  //checkpoint 활성화 
			this.limit.GetComponent<limitzone> ().make = true;   //옆으로 못가게 방지

			music1.GetComponent<AudioSource>().volume=0.0f;
			music2.GetComponent<AudioSource>().volume=100.0f;
		}
	}
}
