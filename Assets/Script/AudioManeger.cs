using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManeger : MonoBehaviour {
    //单例
	public static AudioManeger instance;
	//获取播放组件
	private AudioSource player;

	// Use this for initialization
	void Start () {
		//单例
		instance = this;
		//获取播放组件
		player = GetComponent<AudioSource>();
	}
	
	//播放音效
	public void Play(string name){
		//通过名称获取音频片段
		AudioClip clip = Resources.Load<AudioClip>(name);
		//播放
		player.PlayOneShot(clip);
	}
}
