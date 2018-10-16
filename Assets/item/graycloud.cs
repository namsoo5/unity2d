using UnityEngine;
using System.Collections;

public class graycloud : MonoBehaviour {
	//float speed;

	float timer;
	// Use this for initialization
	void Start () {
	
		//speed = Random.Range (0.03f, 0.07f);
	}
	
	// Update is called once per frame
	void Update () {

		timer += Time.deltaTime;

		if (timer > 3.5)
			Destroy (gameObject);



	}
		
}
