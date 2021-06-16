using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputControl : MonoBehaviour {
	List<Score> scoreList = new List<Score>(); //创建list，用来存Score
	public Text ps;
	// Use this for initialization
	void Start () {
		//添加监听事件
        transform.GetComponent<InputField>().onEndEdit.AddListener(End);
		transform.localPosition = new Vector3(0,11111,0);
	}
	
	// Update is called once per frame
	void Update () {
		if(playerControl.Hp == 0){
			transform.localPosition = new Vector3(0,0,0);
			submit();
		}
	}

    void End(string str)
    {
        Debug.Log("输入结果为"+str);
    }
	
	//点击提交
	public void submit(){
		scoreList.Add(new Score(ps.text, playerControl.score));
	}
}
