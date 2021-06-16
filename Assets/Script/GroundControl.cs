using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundControl : MonoBehaviour {

	//速度
	public float Speed = 4f;
	//要随机的地面数组
	public GameObject[] GroundPrefabs;

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
				//创建新的地面
				Transform newTran = Instantiate(GroundPrefabs[Random.Range(0,GroundPrefabs.Length)],transform).transform;
				//获取新地面的位置
				Vector2 newPos = newTran.position;
				//设置新地面的位置
				newPos.x = pos.x + 20.5f*2;
				//位置设置回去
				newTran.position = newPos;
				//销毁旧的地面（就是出了屏幕的地面）
				Destroy(tran.gameObject);
			}
			//位置赋给子物体
			tran.position = pos;
		}
	}
}
