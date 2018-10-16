using UnityEngine;
using System.Collections;

public class railcloud : MonoBehaviour {
	GameObject player;
	// Use this for initialization
	void Start () {
		this.player = GameObject.Find ("cat");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionStay2D(Collision2D other){
		if (other.gameObject.tag == "Player") {
			this.player.transform.Translate (-0.05f, 0, 0);
		}
	}

}
