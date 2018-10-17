using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {
	Rigidbody2D rigid2D;
	Animator animator;
	float jumpForce = 680.0f;
	//float walkForce = 30.0f;좌우움직임을위한 삭제
	//float maxWalkSpeed = 3.0f;  좌우움직임을위한 삭제
	float time = 0;  // item timer
	bool timerstart = false; // timer start
	GameObject life;
	GameObject broke;
	//bool visi; //item effect animation speed;  좌우움직임을위한삭제
	public bool getwing=false; //item effect wing
	float wingcount=0;
	public bool save = false;
	public bool change = false;  //change item effect
	float changecount = 0;
	public bool jump=false;
	// Use this for initialization
	void Start () {
		this.rigid2D = GetComponent<Rigidbody2D> ();
		this.animator = GetComponent<Animator> ();
		this.life = GameObject.Find ("heart");
		this.broke = GameObject.Find ("brokecloud");

	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKey(KeyCode.R))
			this.transform.position = new Vector3(4,33,0);


		//점프
		//visi = this.animator.GetBool ("Visible");   //좌우움직임을위한삭제
		//float speedx = Mathf.Abs (this.rigid2D.velocity.x);  좌우움직임을위한 삭제 

		if (Input.GetKeyDown (KeyCode.Space) && (jump || this.rigid2D.velocity.y ==0)) { //velocity는 가해지는 힘
			this.animator.SetTrigger ("JumpTrigger");
			this.rigid2D.AddForce (transform.up * this.jumpForce);
			//jump = false;
		}

		//좌우이동
		int key = 0;
		if (change) {
			changecount += Time.deltaTime;
			if (Input.GetKey (KeyCode.RightArrow)) {
				transform.Translate (-0.07f, 0, 0);
				key = -1;
			}
			if (Input.GetKey (KeyCode.LeftArrow)) {
				transform.Translate (0.07f, 0, 0);
				key = 1;
			}

			if (changecount > 6) {
				change = false;
				changecount = 0;
			}
			
		} else {
			if (Input.GetKey (KeyCode.RightArrow)) {
				transform.Translate (0.07f, 0, 0);
				key = 1;
			}
			if (Input.GetKey (KeyCode.LeftArrow)) {
				transform.Translate (-0.07f, 0, 0);
				key = -1;
			}
		}

		/*if (speedx < this.maxWalkSpeed) {
			this.rigid2D.AddForce (transform.right * key * this.walkForce);
		}
		좌우움직임을위한 삭제*/

		//방향에따른 이미지반전
		if (key != 0) {
			transform.localScale = new Vector3 (key, 1, 1);
		}

		if (timerstart)
			this.animator.speed = 0.5f;
		else {
			if (this.rigid2D.velocity.y != 0 || key != 0)
				this.animator.speed = 1.0f;
			else
				this.animator.speed = 0.0f;
		}

		/*if (visi) {
			
		}else	if (this.rigid2D.velocity.y == 0) {
			this.animator.speed = 1.0f; //플레이어속도에맞춰 애니메이션속도를 바꾼다.
		} else {
			this.animator.speed = 1.0f;
		}  좌우움직임을위한 삭제시 중복코드
*/

		if (transform.position.y < -10) {
				this.transform.position = new Vector3 (0, 0, 0);
				this.life.GetComponent<life> ().death ();  //life 감소
				this.broke.SetActive (true);
		}

		if (save && transform.position.y <24) {
			this.rigid2D.AddForce (transform.up * 400f);  //구름뚫는 버그수정 
			this.transform.position = new Vector3(3,31,0);
			this.life.GetComponent<life> ().death ();
			this.broke.SetActive (true);
		}


		if (timerstart) {   //ghost item
			time += Time.deltaTime;
			if (time > 5) { //5초 동안 깜박임
				animator.SetBool ("Visible", false);
				timerstart = false;
				time = 0;
			}
		}

		if (getwing) { //wing item
			GetComponent<Rigidbody2D> ().AddForce (transform.up * 35f);
			wingcount += Time.deltaTime;
			if (wingcount > 3) {
				getwing = false;
				wingcount = 0;
			}
		}



	}
	void OnCollisionEnter2D(Collision2D other){
		if (other.gameObject.tag == "item") {  //ghost item effect
			timerstart = true;
		}
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "Finish") {
			SceneManager.LoadScene ("ClearScene");
		}
	}




}
