using UnityEngine;
using System.Collections;

public class grayCtrl : MonoBehaviour {
	public GameObject grayPre;
	float time;
	int py;
	int px;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		time += Time.deltaTime;

		if (time > 0.6f) {
			GameObject gray = Instantiate (grayPre) as GameObject;
			py = Random.Range (28, 32);
			px = Random.Range (22, 30);
			gray.transform.position = new Vector3 (px, py, 0);  //make random position
			time = 0;
		}
	}


}
