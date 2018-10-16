using UnityEngine;
using System.Collections;

public class brokecloud : MonoBehaviour {
	float time=0;
	bool count=false;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (count) {
			time += Time.deltaTime;
			if (time > 1) {
				time = 0;
				gameObject.SetActive (false);  //1초 경과 하면 삭제
				count = false;
			}
		}
	}
		
	void OnCollisionEnter2D(Collision2D other){
		if (other.gameObject.tag == "Player") {
			count = true;

		}
	}
}
