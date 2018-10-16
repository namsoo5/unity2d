using UnityEngine;
using System.Collections;


public class arrowctrl : MonoBehaviour {
	public GameObject arrowPre;
	float time;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		time += Time.deltaTime;

		if (time > 3) {
			GameObject arrow = Instantiate (arrowPre) as GameObject;
			int px = Random.Range (-3, 3);
			arrow.transform.position = new Vector3 (px, 36, 0);
			time = 0;
		}
	}
		
}
