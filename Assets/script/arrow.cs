using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class arrow : MonoBehaviour {
	GameObject life;
	// Use this for initialization
	void Start () {
		this.life = GameObject.Find ("heart");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "Player") {
			this.life.GetComponent<life> ().halfdeath();
			Destroy (gameObject);
		}
	}
}
