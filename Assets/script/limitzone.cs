using UnityEngine;
using System.Collections;

public class limitzone : MonoBehaviour {
	GameObject limit;
	public bool make;
	// Use this for initialization
	void Start () {
		this.limit = GameObject.Find("limitzone");

	}
	
	// Update is called once per frame
	void Update () {
		if (make) {
			this.limit.SetActive (true);  //checkpoint시 제한 구역 생김 
		} else {
			this.limit.SetActive (false);
		}
	}

}
