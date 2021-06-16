using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinControl : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//如果产生触发
	private void OnTriggerEnter2D(Collider2D collision){
		//播放星星音效
		AudioManeger.instance.Play("金币");
		//销毁金币等
		Destroy(gameObject);
	}
}
