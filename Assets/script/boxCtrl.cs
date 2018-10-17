using UnityEngine;
using System.Collections;

public class boxCtrl : MonoBehaviour {
	Animator animator;
	int item;
	bool state = false;
	GameObject itemselect; 
	Vector3 boxpos;
	// Use this for initialization
	void Start () {
		this.animator = gameObject.GetComponent<Animator> ();
		this.itemselect = GameObject.Find ("itemselect");
		boxpos = gameObject.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "Player" && state == false) {
			state = true;
			this.animator.SetTrigger ("open");
			item = Random.Range (1, 5);  //ramdom item drop select
			itemselect.GetComponent<item>().items(this.item, boxpos);
		}
	}
}
