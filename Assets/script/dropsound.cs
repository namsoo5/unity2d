using UnityEngine;
using System.Collections;
using UnityEngine.Audio;

public class dropsound : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void startmusic(){
		GetComponent<AudioSource> ().Play ();
	}
}
