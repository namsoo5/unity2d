using UnityEngine;
using System.Collections;

public class item : MonoBehaviour {
	//public GameObject ghostPre;
	// Use this for initialization
	public GameObject ghostPre;
	public GameObject wingPre;
	public GameObject lifePre;
	public GameObject changePre;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void items(int n, Vector3 v){    //random item drop
		switch (n) {
		case 1:
			Debug.Log ("유령");
			GameObject item1 = Instantiate (ghostPre) as GameObject;
			item1.transform.position = v;
			break;
		case 2:
			Debug.Log ("wing");
			GameObject item2 = Instantiate (wingPre) as GameObject;
			item2.transform.position = v;
			break;
		case 3:
			Debug.Log ("life");
			GameObject item3 = Instantiate (lifePre) as GameObject;
			item3.transform.position = v;
			break;
		case 4:
			Debug.Log ("좌우변경");
			GameObject item4 = Instantiate (changePre) as GameObject;
			item4.transform.position = v;
			break;
		}


	}
}
