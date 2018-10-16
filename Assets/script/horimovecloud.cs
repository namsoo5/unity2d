using UnityEngine;
using System.Collections;

public class horimovecloud : MonoBehaviour {
	float timer;
	bool move=false;
	GameObject player;
	// Use this for initialization
	void Start () {
		this.player = GameObject.Find ("cat");
	}
	
	// Update is called once per frame
	void Update () {
	
		timer += Time.deltaTime;

		if (timer < 3) {
			gameObject.transform.Translate (0.04f, 0, 0);
			if(move)
				this.player.transform.Translate (0.04f, 0, 0);
		}
		else {
			gameObject.transform.Translate (-0.04f, 0, 0);
			if(move)
				this.player.transform.Translate (-0.04f, 0, 0);
			if (timer > 6)
				timer = 0;
		}
	}

	void OnCollisionStay2D(Collision2D other){
		if (other.gameObject.tag == "Player") {  //ghost item effect
			move = true;
		}
	}
	void OnCollisionExit2D(Collision2D other){
		if (other.gameObject.tag == "Player") {  //ghost item effect
			move = false;
		}
	}
}
