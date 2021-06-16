using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgControl : MonoBehaviour {
	//速度
	public float Speed = 0.3f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//如果玩家血量为0，界面静止
		if(playerControl.Hp == 0){
			return;
		}
		if(player2.Hp == 0){
			return;
		}
		//遍历背景，子物体
		foreach(Transform tran in transform){
			//获取子物体的位置
			Vector3 pos = tran.position;
			//按照速度向左侧移动
			pos.x -=Speed*Time.deltaTime;
			//判断图片是否出了屏幕
			if(pos.x < -20.5f){
				//把图片移动到右边
				pos.x += 20.5f*2;
			}
			//位置赋给子物体
			tran.position = pos;
		}
	}
}
