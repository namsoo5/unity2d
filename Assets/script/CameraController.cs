using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	GameObject player;
	bool check;
	// Use this for initialization
	void Start () {
		this.player = GameObject.Find ("cat");

	}
	
	// Update is called once per frame
	void Update () {
		this.check = this.player.GetComponent<PlayerController> ().save;
		Vector3 playerPos = this.player.transform.position;
		if (check) {
			transform.position = new Vector3 (
				playerPos.x, transform.position.y, transform.position.z);
		} else {
			transform.position = new Vector3 (
				transform.position.x, playerPos.y, transform.position.z);
		}
	}
}
