using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player2 : MonoBehaviour {


	public static int count1 = 0;
	public Text oneCount;
	public static int count2 = 0;
	public Text twoCount;
	public static int count3 = 0;
	public Text threeCount;

	//分数
	public static int score = 0;
	public Text scoreTxt;

	//排行榜
	public GameObject phb;

	//血量
	public static int Hp = 1;
	//刚体组件
	private Rigidbody2D rbody;
	//动画组件
	private Animator ani;
	//当前是否碰到了地面
	private bool isGround;

	// Use this for initialization
	void Start () {
		Time.timeScale = 1.3f;
		//获取刚体组件
		rbody = GetComponent<Rigidbody2D>();
		//获取动画组件
		ani = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		//如果按了空格键就跳跃
		if(Input.GetKeyDown(KeyCode.Space)){
			//跳跃
			jump();
		}
		if(score == 800){
			Time.timeScale = 2f;
		}
		else if(score == 1000){
			Time.timeScale = 3f;
		}
		else if(score == 2000){
			Time.timeScale = 5f;
		}
	}

	//跳跃
	public void jump(){
		//如果在地面上才允许跳跃
		if(isGround == true){
			//给刚体一个向上的力
		    rbody.AddForce(Vector2.up*600);
		    //播放跳跃声音
		    AudioManeger.instance.Play("跳");
		}
	}

    //产生碰撞
	private void OnCollisionEnter2D(Collision2D collision){
		//如果碰到地面
		if(collision.collider.tag == "Ground"){
			isGround = true;
			//结束跳跃
			ani.SetBool("IsJump",false);
		}

		//如果碰到死亡边界
		if(collision.collider.tag == "Die" && Hp > 0){
			//血量为零
			Hp = 0;
			//播放死亡声音
			AudioManeger.instance.Play("Boss死了");
			//播放死亡动画
			ani.SetBool("IsDie",true);
			//获取到排行榜组件
			rank rank=(rank)phb.GetComponent<rank>();
			rank.died(score);//需要传入当前的分数
		}
	}
    //结束碰撞
	private void OnCollisionExit2D(Collision2D collision){
		//如果碰到地面
		if(collision.collider.tag == "Ground"){
			isGround = false;
			//开始跳跃
			ani.SetBool("IsJump",true);
		}
	}

	//如果碰到敌人
	private void OnTriggerEnter2D(Collider2D collision){
		if(collision.tag == "enemy" && Hp > 0){
			//血量为零
			Hp = 0;
			//播放死亡声音
			AudioManeger.instance.Play("Boss死了");
			//播放死亡动画
			ani.SetBool("IsDie",true);
			//获取到排行榜组件
			rank rank=(rank)phb.GetComponent<rank>();
			rank.died(score);//需要传入当前的分数
		}

        //碰到火焰
		if(collision.tag == "fire" && Hp > 0){
			//血量为零
			Hp = 0;
			//播放死亡声音
			AudioManeger.instance.Play("Boss死了");
			//播放死亡动画
			ani.SetBool("IsDie",true);
			//获取到排行榜组件
			rank rank=(rank)phb.GetComponent<rank>();
			rank.died(score);//需要传入当前的分数
		}

		//如果碰到星星
			if(collision.tag == "coin1" ){
			count1 += 1;
			score += 10;
			oneCount.text = count1.ToString();
			scoreTxt.text = score.ToString ();
		}

		//如果碰到金币
			if(collision.tag == "coin2" ){
			count2 += 1;
			twoCount.text = count2.ToString();
			score += 30;
			scoreTxt.text = score.ToString ();
		}

		//如果碰到金环
			if(collision.tag == "coin3" ){
			count3 += 1;
			threeCount.text = count3.ToString();
			score += 50;
			scoreTxt.text = score.ToString ();
		}
	}
}
