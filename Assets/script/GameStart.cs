using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class GameStart : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		

	}

	public void startclick(){
		SceneManager.LoadScene ("Gamescene");
	}

	public void explainclick(){
		SceneManager.LoadScene ("ExplainScene");
	}
	public void clear(){
		SceneManager.LoadScene ("GameStart");
	}
}
