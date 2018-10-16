using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class life : MonoBehaviour {
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		//if amount ==0 gameover
	}
	public void death(){
		this.GetComponent<Image> ().fillAmount -= 0.335f;
		if(this.GetComponent<Image> ().fillAmount <=0)   //생명 0이면  gameover
			SceneManager.LoadScene ("GameOver");
	}
	public void halfdeath(){
		this.GetComponent<Image> ().fillAmount -= 0.335f / 2;
		if(this.GetComponent<Image> ().fillAmount <=0)   //생명 0이면  gameover
			SceneManager.LoadScene ("GameOver");
	}

	public void heal(){
		this.GetComponent<Image> ().fillAmount += 0.335f;
	}
}
